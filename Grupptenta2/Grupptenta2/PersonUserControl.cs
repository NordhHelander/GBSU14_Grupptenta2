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

		private static Person _person;
		private static CompanyManager _companyManager;
		private static Company _company;

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
			_company = companyManager.Companies.SingleOrDefault(c => c.Employees.Any(e => e.Id == _person.Id));

			// Se till att lösenords-knappen syns om det är den egna profilen man är inne på.

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
			noteBox.DataSource = _person.Notes;
			isActiveCheckBox.Checked = _person.IsActive;
		}
		private void saveBtn_Click(object sender, EventArgs e)
		{
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

			if (OnSavePersonChanges != null)
				OnSavePersonChanges();
			//if (companyBox.SelectedItem != _company)
			//{
			//	_company.Employees.Remove(_person);
			//	Company selectedCompany = (Company)companyBox.SelectedItem;
			//	Company companyToMovePersonTo = _companyManager.Companies.SingleOrDefault(c => c.Id == selectedCompany.Id);
			//	companyToMovePersonTo.Employees.Add(_person);
			//	_company = companyToMovePersonTo;
			//}
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
}
