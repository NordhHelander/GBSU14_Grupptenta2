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

		public void OpenForEdit()
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
			companyBox.ReadOnly = false;
			notesBox.ReadOnly = false;
			activeBox.Enabled = true;
		}

		public void HideEditBtn()
		{
			editBtn.Visible = false;
		}

		public void BindPerson(Person person, BindingList<Company> companies)
		{
			Company company = companies.SingleOrDefault(c => c.Employees.Any(e => e.Id == person.Id));

			firstNameBox.Text = person.FirstName;
			lastNameBox.Text = person.LastName;
			dobBox.Text = person.Birthdate.ToShortDateString();
			//streetbox.text = person.residentaladdress.street;
			//postalcodebox.text = person.residentaladdress.zipcode;
			//citybox.text = person.residentaladdress.city;
			phoneBox.Text = person.PhoneNumber;
			cellPhoneBox.Text = person.CellPhoneNumber;
			emailBox.Text = person.EmailAddress;
			typeBox.Text = person.Type;
			companyBox.Text = company.Name;
			//notesBox.Text = person.Notes;
			activeBox.Checked = person.IsActive;
		}

		private void OpenForEdit(object sender, EventArgs e)
		{
			OpenForEdit();
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			if (OnSaveChanges != null)
				OnSaveChanges(sender, new SaveChangesHandlerEventArgs(firstNameBox.Text, lastNameBox.Text));
		}
	}

	public class SaveChangesHandlerEventArgs : EventArgs
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public SaveChangesHandlerEventArgs(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

	}
}
