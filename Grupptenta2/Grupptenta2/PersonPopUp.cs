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
	public partial class PersonPopUp : Form
	{
		private static Person _person;
		private static CompanyManager _companyManager;
		private static ProjectManager _projectManager;

		public PersonPopUp(Person person, CompanyManager companyManager, ProjectManager projectManager)
		{
			_person = person;
			_companyManager = companyManager;
			_projectManager = projectManager;

			InitializeComponent();
			this.Text = _person.ToString();
			LoadPerson();

			personInfoBox.OnSaveChanges += personInfoBox_OnSaveChanges;
		}

		private void personInfoBox_OnSaveChanges(object sender, SaveChangesHandlerEventArgs e)
		{
			_person.FirstName = e.FirstName;
			_person.LastName = e.LastName;
			_person.Birthdate = e.DateOfBirth;
			_person.ResidentalAddress.Street = e.Street;
			_person.ResidentalAddress.ZipCode = e.PostalCode;
			_person.ResidentalAddress.City = e.City;
			_person.PhoneNumber = e.PhoneNumber;
			_person.CellPhoneNumber = e.CellPhoneNumber;
			_person.EmailAddress = e.EmailAddress;
			_person.Type = e.Type;
			// Ska läggas in metod för att ändra företag. Måste välja bland befintliga och tas bort från tidigare företag.
			this.Text = _person.ToString();
		}

		private void LoadPerson()
		{
			personInfoBox.BindPerson(_person, _companyManager.Companies);
			projectBox.SetData("Projects", _projectManager.Projects, "Name");
			relationBox.SetData("Närstående", _person.Relations, "Person");
		}


	}
}