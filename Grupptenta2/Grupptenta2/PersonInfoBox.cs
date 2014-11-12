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

namespace Grupptenta2
{
	public partial class PersonInfoBox : UserControl
	{
		public delegate void SaveChangesEventHandler(object sender, SaveChangesHandlerEventArgs e);
		public event SaveChangesEventHandler OnSaveChanges;

		public PersonInfoBox()
		{
			InitializeComponent();
		}

		public void BindPerson(Person person, BindingList<Company> companies)
		{
			Company company = companies.SingleOrDefault(c => c.Employees.Any(e => e.Id == person.Id));
			companyBox.DataSource = companies;

			firstNameBox.Text = person.FirstName;
			lastNameBox.Text = person.LastName;
			dobBox.Text = person.Birthdate.ToShortDateString();
			streetBox.Text = person.ResidentalAddress.Street;
			postalCodeBox.Text = person.ResidentalAddress.ZipCode;
			cityBox.Text = person.ResidentalAddress.City;
			phoneBox.Text = person.PhoneNumber;
			cellPhoneBox.Text = person.CellPhoneNumber;
			emailBox.Text = person.EmailAddress;
			typeBox.Text = person.Type;
			companyBox.DisplayMember = "Name";
			companyBox.SelectedItem = company;
			//notesBox.Text = person.Notes;
			activeBox.Checked = person.IsActive;
		}

		public void BindCompanyBox(object dataSource, string displayMember)
		{
			companyBox.DataSource = null;
			companyBox.DataSource = dataSource;
			companyBox.DisplayMember = displayMember;
		}

		private void editBtn_Click(object sender, EventArgs e)
		{
			EnableEdit();
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			if (OnSaveChanges != null)
				OnSaveChanges(sender, new SaveChangesHandlerEventArgs(firstNameBox.Text, lastNameBox.Text, DateTime.Parse(dobBox.Text), streetBox.Text,
					postalCodeBox.Text, cityBox.Text, phoneBox.Text, cellPhoneBox.Text, emailBox.Text, typeBox.Text, (Company)companyBox.SelectedItem));

			DisableEdit();
		}

		public void EnableEdit()
		{
			firstNameBox.ReadOnly = false;
			lastNameBox.ReadOnly = false;
			dobBox.ReadOnly = false;
			streetBox.ReadOnly = false;
			postalCodeBox.ReadOnly = false;
			cityBox.ReadOnly = false;
			phoneBox.ReadOnly = false;
			cellPhoneBox.ReadOnly = false;
			emailBox.ReadOnly = false;
			typeBox.ReadOnly = false;
			companyBox.Enabled = true;
			notesBox.ReadOnly = false;
			activeBox.Enabled = true;
		}

		private void DisableEdit()
		{
			firstNameBox.ReadOnly = true;
			lastNameBox.ReadOnly = true;
			dobBox.ReadOnly = true;
			streetBox.ReadOnly = true;
			postalCodeBox.ReadOnly = true;
			cityBox.ReadOnly = true;
			phoneBox.ReadOnly = true;
			cellPhoneBox.ReadOnly = true;
			emailBox.ReadOnly = true;
			typeBox.ReadOnly = true;
			companyBox.Enabled = false;
			notesBox.ReadOnly = true;
			activeBox.Enabled = false;
		}

		public void HideEditBtn()
		{
			editBtn.Visible = false;
		}
	}

	public class SaveChangesHandlerEventArgs : EventArgs
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Street { get; set; }
		public string PostalCode { get; set; }
		public string City { get; set; }
		public string PhoneNumber { get; set; }
		public string CellPhoneNumber { get; set; }
		public string EmailAddress { get; set; }
		public string Type { get; set; }
		public Company Company { get; set; }
		//public string Notes { get; set; } Egentligen lista <Note>

		public SaveChangesHandlerEventArgs(string firstName, string lastName, DateTime dateOfBirth, string street, string postalCode, string city, string phoneNumber, string cellPhoneNumber, string emailAddress, string type, Company company)
		{
			FirstName = firstName;
			LastName = lastName;
			DateOfBirth = dateOfBirth;
			Street = street;
			PostalCode = postalCode;
			City = city;
			PhoneNumber = phoneNumber;
			CellPhoneNumber = cellPhoneNumber;
			EmailAddress = emailAddress;
			Type = type;
			Company = company;
		}
	}
}
