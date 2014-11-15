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
		public delegate void SavePersonChangesEventHandler(object sender, SavePersonChangesHandlerEventArgs e);
		public delegate void ClosePopUpEventHandler();

		public event SavePersonChangesEventHandler OnSavePersonChanges;
		public event ClosePopUpEventHandler OnClosePopUp;

		private static Person _person;
		private static CompanyManager _companyManager;

		public PersonUserControl()
		{
			InitializeComponent();

			typeBox.DataSource = new List<string> { "Anställd", "Konsult", "Kontakt", "Närstående" };
		}

		public void HidePopUpBtn()
		{
			popUpBtn.Visible = false;
		}

		public void SetPersonInfo(Person person, CompanyManager companyManager)
		{
			_person = person;
			_companyManager = companyManager;

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
			companyBox.SelectedItem = companyManager.Companies.SingleOrDefault(c => c.Employees.Any(e => e.Id == _person.Id));
			noteBox.DataSource = _person.Notes;
			activeCheckBox.Checked = _person.IsActive;

			//projectBox.DataSource =					Ska sättas till lista över projekt som personen är med i.
			//projectBox.DisplayMember = "Name";
			//contactBox.DataSource =					Ska sättas till personer som personen är relaterad till.
			//contactBox.DisplayMember = "Person";
		}
		private void editSaveBtn_Click(object sender, EventArgs e)
		{
			if (editSaveBtn.Text == "Redigera")
			{
				firstNameBox.ReadOnly = false;
				lastNameBox.ReadOnly = false;
				birthdateBox.ReadOnly = false;
				streetBox.ReadOnly = false;
				zipBox.ReadOnly = false;
				cityBox.ReadOnly = false;
				phoneBox.ReadOnly = false;
				cellPhoneBox.ReadOnly = false;
				emailBox.ReadOnly = false;
				typeBox.Enabled = true;
				companyBox.Enabled = true;
				noteBox.Enabled = true;
				activeCheckBox.Enabled = true;

				editSaveBtn.Text = "Spara";
				addNoteBtn.Visible = true;
				passwordBtn.Visible = true;
			}
			else if (editSaveBtn.Text == "Spara")
			{
				firstNameBox.ReadOnly = true;
				lastNameBox.ReadOnly = true;
				birthdateBox.ReadOnly = true;
				streetBox.ReadOnly = true;
				zipBox.ReadOnly = true;
				cityBox.ReadOnly = true;
				phoneBox.ReadOnly = true;
				cellPhoneBox.ReadOnly = true;
				emailBox.ReadOnly = true;
				typeBox.Enabled = false;
				companyBox.Enabled = false;
				noteBox.Enabled = false;
				activeCheckBox.Enabled = false;

				if (OnSavePersonChanges != null)
					OnSavePersonChanges(sender, new SavePersonChangesHandlerEventArgs(firstNameBox.Text, lastNameBox.Text, DateTime.Parse(birthdateBox.Text), streetBox.Text,
						zipBox.Text, cityBox.Text, phoneBox.Text, cellPhoneBox.Text, emailBox.Text, (string)typeBox.SelectedItem, (Company)companyBox.SelectedItem, (List<Note>)noteBox.DataSource, activeCheckBox.Checked));

				editSaveBtn.Text = "Redigera";
				addNoteBtn.Visible = false;
				passwordBtn.Visible = false;
			}
		}

		private void popUpBtn_Click(object sender, EventArgs e)
		{
			PersonPopUp personPopUp = new PersonPopUp(_person, _companyManager);
			personPopUp.ShowDialog();
			SetPersonInfo(_person, _companyManager);

			if (OnClosePopUp != null)
				OnClosePopUp();
		}
	}

	public class SavePersonChangesHandlerEventArgs : EventArgs
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Street { get; set; }
		public string ZipCode { get; set; }
		public string City { get; set; }
		public string PhoneNumber { get; set; }
		public string CellPhoneNumber { get; set; }
		public string EmailAddress { get; set; }
		public string Type { get; set; }
		public Company Company { get; set; }
		public List<Note> Notes { get; set; }
		public bool IsActive { get; set; }

		public SavePersonChangesHandlerEventArgs(string firstName, string lastName, DateTime dateOfBirth, string street, string zipCode, string city, string phoneNumber, string cellPhoneNumber, string emailAddress, string type, Company company, List<Note> notes, bool isActive)
		{
			FirstName = firstName;
			LastName = lastName;
			DateOfBirth = dateOfBirth;
			Street = street;
			ZipCode = zipCode;
			City = city;
			PhoneNumber = phoneNumber;
			CellPhoneNumber = cellPhoneNumber;
			EmailAddress = emailAddress;
			Type = type;
			Company = company;
			Notes = notes;
			IsActive = isActive;
		}
	}
}
