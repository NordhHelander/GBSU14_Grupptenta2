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
		public PersonInfoBox()
		{
			InitializeComponent();
		}

		public void BindPerson(Person person, List<Company> companies)
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
	}
}
