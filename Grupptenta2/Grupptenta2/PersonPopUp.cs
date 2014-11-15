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

		public PersonPopUp(Person person, CompanyManager companyManager)
		{
			_person = person;

			InitializeComponent();
			this.Text = _person.ToString();
			personControl.SetPersonInfo(_person, companyManager);
			personControl.OnSavePersonChanges += personControl_OnSavePersonChanges;
			personControl.HidePopUpBtn();
		}

		private void personControl_OnSavePersonChanges(object sender, SavePersonChangesHandlerEventArgs e)
		{
			_person.FirstName = e.FirstName;
			_person.LastName = e.LastName;
			_person.Birthdate = e.DateOfBirth;
			_person.ResidentialAddress.Street = e.Street;
			_person.ResidentialAddress.ZipCode = e.ZipCode;
			_person.ResidentialAddress.City = e.City;
			_person.PhoneNumber = e.PhoneNumber;
			_person.CellPhoneNumber = e.CellPhoneNumber;
			_person.EmailAddress = e.EmailAddress;
			_person.Type = e.Type;
			// Ska läggas in sätt att ändra företag. Måste välja bland befintliga och tas bort från tidigare företag.
			this.Text = _person.ToString();
		}
	}
}
