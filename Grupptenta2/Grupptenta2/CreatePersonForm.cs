using CodeBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestClasses;

namespace Grupptenta2
{
	public partial class CreatePersonForm : Form
	{
		private static PersonManager _personManager;
		private static CompanyManager _companyManager;

		public CreatePersonForm(PersonManager personManager, CompanyManager companyManager)
		{
			_personManager = personManager;
			_companyManager = companyManager;

			InitializeComponent();
			personInfoBox.HideEditBtn();
			personInfoBox.EnableEdit();
			personInfoBox.BindCompanyBox(_companyManager.GetCompanies(), "Name");
			personInfoBox.OnSaveChanges += personInfoBox_OnSaveChanges;
		}

		private void personInfoBox_OnSaveChanges(object sender, SaveChangesHandlerEventArgs e)
		{
			_personManager.CreatePerson(e.FirstName);
			int indexOfNewPerson = _personManager.GetPersons().Count - 1;
			Person person = _personManager.GetPersons()[indexOfNewPerson];

			person.LastName = e.LastName;
			person.Birthdate = e.DateOfBirth;
			person.ResidentalAddress.Street = e.Street;
			person.ResidentalAddress.ZipCode = e.PostalCode;
			person.ResidentalAddress.City = e.City;
			person.PhoneNumber = e.PhoneNumber;
			person.CellPhoneNumber = e.CellPhoneNumber;
			person.EmailAddress = e.EmailAddress;
			person.Type = e.Type;

			_companyManager.GetCompanies().SingleOrDefault(c => c == e.Company).Employees.Add(person);
		}


	}
}
