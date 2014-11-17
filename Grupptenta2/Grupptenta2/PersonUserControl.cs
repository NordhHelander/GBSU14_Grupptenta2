using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeBase;
using TestClasses;

namespace Grupptenta2
{
	public partial class PersonUserControl : UserControl
	{
		public delegate void SavePersonChangesEventHandler();
		public delegate void ClosePopUpEventHandler();

		public event SavePersonChangesEventHandler OnSavePersonChanges;
		public event ClosePopUpEventHandler OnClosePopUp;

		private static PersonManager _personManager;
		private static CompanyManager _companyManager;
		private static ProjectManager _projectManager;
		private static Person _person;
		private static Company _company;
		private static bool _newPerson;
		private static BindingList<Note> _tempNotes;

		public PersonUserControl()
		{
			InitializeComponent();
			typeBox.DataSource = new List<string> { "Anställd", "Konsult", "Kontakt", "Närstående" };
		}

		public void HidePopUpBtn()
		{
			popUpBtn.Visible = false;
		}

		public void SetupForCreatePerson(PersonManager personManager, CompanyManager companyManager)
		{
			_newPerson = true;
			_personManager = personManager;
			_companyManager = companyManager;

			firstNameBox.Text = "Förnamn";
			lastNameBox.Text = "Efternamn";
			birthdateBox.Text = "ÅÅÅÅ-MM-DD";
			_tempNotes = new BindingList<Note>();
			notesBox.DataSource = _tempNotes;
			notesBox.DisplayMember = "Note";
			companyBox.DataSource = _companyManager.Companies;
			companyBox.DisplayMember = "Name";
		}

		public void SetPersonInfo(Person person, CompanyManager companyManager, ProjectManager projectManager)
		{
			_newPerson = false;
			_person = person;
			_companyManager = companyManager;
			_projectManager = projectManager;
			_company = companyManager.Companies.SingleOrDefault(c => c.Employees.Any(e => e.Id == _person.Id));

			firstNameBox.Text = _person.FirstName;
			lastNameBox.Text = _person.LastName;
			birthdateBox.Text = _person.Birthdate.ToShortDateString();
			streetBox.Text = _person.ResidentialAddress.Street;
			zipBox.Text = _person.ResidentialAddress.ZipCode;
			cityBox.Text = _person.ResidentialAddress.City;
			phoneBox.Text = _person.PhoneNumber;
			cellPhoneBox.Text = _person.CellPhoneNumber;
			emailBox.Text = _person.EmailAddress;
			typeBox.Text = _person.Type;
			companyBox.DataSource = companyManager.Companies;
			companyBox.DisplayMember = "Name";
			companyBox.SelectedItem = _company;
			notesBox.DataSource = _person.Notes;
			isActiveCheckBox.Checked = _person.IsActive;

			_tempNotes = _person.Notes;
			notesBox.DataSource = _tempNotes;
			notesBox.DisplayMember = "Note";
		}
		
		private void saveBtn_Click(object sender, EventArgs e)
		{
			if (_newPerson)
			{
				_personManager.CreatePerson(firstNameBox.Text);
				_person = _personManager.Persons[_personManager.Persons.Count - 1];
			}
			_person.FirstName = firstNameBox.Text;
			_person.LastName = lastNameBox.Text;
			_person.Birthdate = DateTime.Parse(birthdateBox.Text);
			_person.ResidentialAddress.Street = streetBox.Text;
			_person.ResidentialAddress.ZipCode = zipBox.Text;
			_person.ResidentialAddress.City = cityBox.Text;
			_person.PhoneNumber = phoneBox.Text;
			_person.CellPhoneNumber = cellPhoneBox.Text;
			_person.EmailAddress = emailBox.Text;
			_person.Type = (string)typeBox.SelectedItem;
			_person.IsActive = isActiveCheckBox.Checked;

			_person.Notes = _tempNotes;

			//if (companyBox.SelectedItem != _company)
			//{
			//	_company.Employees.Remove(_person);
			//	Company selectedCompany = (Company)companyBox.SelectedItem;
			//	Company companyToMovePersonTo = _companyManager.Companies.SingleOrDefault(c => c.Id == selectedCompany.Id);
			//	companyToMovePersonTo.Employees.Add(_person);
			//	_company = companyToMovePersonTo;
			//}

			if (OnSavePersonChanges != null)
				OnSavePersonChanges();
		}

		private void popUpBtn_Click(object sender, EventArgs e)
		{
			PersonPopUp personPopUp = new PersonPopUp(_person, _companyManager, _projectManager);
			personPopUp.ShowDialog();
			SetPersonInfo(_person, _companyManager, _projectManager);

			if (OnClosePopUp != null)
				OnClosePopUp();
		}

		private void addNoteBtn_Click(object sender, EventArgs e)
		{
			Note note = new Note();
			// Se till att author blir = inloggad personal.
			note.NoteDate = DateTime.Now;
			note.Text = newNoteBox.Text;
			note.IsPublic = isPublicNoteCheckBox.Checked;
			newNoteBox.Text = "";

			_tempNotes.Add(note);
		}

		private void removeNoteBtn_Click(object sender, EventArgs e)
		{
			_tempNotes.Remove((Note)notesBox.SelectedItem);
		}
	}
}
