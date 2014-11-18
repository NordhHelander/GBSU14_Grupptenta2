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
		public PersonPopUp(Person person, CompanyManager companyManager, ProjectManager projectManager)
		{
			InitializeComponent();
			this.Text = person.ToString();

			List<Project> projects = projectManager.Projects.Where(p => p.Roles.Any(r => r.Id == person.Id)).ToList();
			personControl.SetPersonInfo(person, companyManager, projectManager);
			personControl.OnSavePersonChanges += personControl_OnSavePersonChanges;

			projectBox.SetHeader("Projekt");
			relationBox.SetHeader("Närstående");
			projectBox.SetButtonTexts("Visa", "Lägg till");
			relationBox.SetButtonTexts("Visa", "Lägg till");
			projectBox.SetData(projects, "Name");
			relationBox.SetData(person.Relations, "Person");
		}

		private void personControl_OnSavePersonChanges()
		{
			this.Close();
		}
	}
}