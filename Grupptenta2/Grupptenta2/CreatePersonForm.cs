using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeBase;
using TestClasses;

namespace Grupptenta2
{
	public partial class CreatePersonForm : Form
	{
		private PersonManager _personManager;
		private CompanyManager _companyManager;

		public CreatePersonForm(PersonManager personManager, CompanyManager companyManager)
		{
			_personManager = personManager;
			_companyManager = companyManager;

			InitializeComponent();

			companyBox.DataSource = _companyManager.Companies;
			companyBox.DisplayMember = "Name";

			typeBox.DataSource = new List<string> { "Anställd", "Konsult", "Kontakt", "Närstående" };
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			_personManager.CreatePerson(firstNameBox.Text);
			int indexOfNewPerson = _personManager.Persons.Count - 1;
			Person person = _personManager.Persons[indexOfNewPerson];

			person.LastName = lastNameBox.Text;
			DateTime birthDate;
			DateTime.TryParse(birthdateBox.Text, out birthDate);
			person.Birthdate = birthDate;
			person.ResidentialAddress.Street = streetBox.Text;
			person.ResidentialAddress.ZipCode = zipBox.Text;
			person.ResidentialAddress.City = cityBox.Text;
			person.PhoneNumber = phoneBox.Text;
			person.CellPhoneNumber = cellPhoneBox.Text;
			person.EmailAddress = emailBox.Text;
			person.Type = (string)typeBox.SelectedItem;
			_companyManager.Companies.SingleOrDefault(c => c == companyBox.SelectedItem).Employees.Add(person);
			//person.Notes = lägg till metod för att lägga till note på knappklick och på dubbelklick i noteBox.
			person.IsActive = activeCheckBox.Checked;
			this.Close();
		}
	}
}
