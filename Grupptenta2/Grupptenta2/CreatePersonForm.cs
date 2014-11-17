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
			personControl.SetupForCreatePerson(_personManager, _companyManager);
			personControl.HidePopUpBtn();
			personControl.OnSavePersonChanges += personControl_OnSavePersonChanges;
		}

		private void personControl_OnSavePersonChanges()
		{
			this.Close();
		}
	}
}
