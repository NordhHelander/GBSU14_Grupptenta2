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
		public CreatePersonForm(PersonManager personManager, CompanyManager companyManager)
		{
			InitializeComponent();
			personControl.SetupForCreatePerson(personManager, companyManager);
			personControl.OnSavePersonChanges += personControl_OnSavePersonChanges;
		}

		public CreatePersonForm(Company company, PersonManager personManager, CompanyManager companyManager)
		{
			InitializeComponent();
			personControl.SetupForCreateEmployee(company, personManager, companyManager);
			personControl.OnSavePersonChanges += personControl_OnSavePersonChanges;
		}

		public CreatePersonForm(bool isRelation, Person person, PersonManager personManager)
		{
			InitializeComponent();
			personControl.SetupForCreateRelation(isRelation, person, personManager);
			personControl.OnSavePersonChanges += personControl_OnSavePersonChanges;
		}

		private void personControl_OnSavePersonChanges()
		{
			this.Close();
		}
	}
}
