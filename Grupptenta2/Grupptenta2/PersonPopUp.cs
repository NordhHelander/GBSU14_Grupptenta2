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

		private void personControl_OnSavePersonChanges()
		{
			this.Text = _person.ToString();
		}
	}
}
