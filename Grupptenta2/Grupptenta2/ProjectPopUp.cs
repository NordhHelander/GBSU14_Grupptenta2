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
	public partial class ProjectPopUp : Form
	{
		private static Project _project;
		private static CompanyManager _companyManager;
		private static ProjectManager _projectManager;

		public ProjectPopUp(Project project, CompanyManager companyManager, ProjectManager projectManager)
		{
			InitializeComponent();
			this.Text = project.Name;
			_project = project;
			_companyManager = companyManager;
			_projectManager = projectManager;

			Company company = companyManager.Companies.SingleOrDefault(c => c.Projects.Any(p => p.Id == project.Id));

			projectNameBox.Text = project.Name;
			projectIdBox.Text = project.Id.ToString();
			projectCompanyBox.Text = company.Name;
			projectDescBox.Text = project.Description;

			projectParticipantBox.SetHeader("Deltagare");
			projectParticipantBox.SetButtonTexts("Visa", "Ändra");
			projectParticipantBox.SetData(project.Roles, "Person");

			projectEventBox.SetHeader("Händelser");
			projectEventBox.SetButtonTexts("Visa", "Ändra");
			projectEventBox.SetData(project.ProjectJournal.Events, "ProjectEvent");

			projectNoteBox.SetHeader("Anteckningar");
			projectNoteBox.SetButtonTexts("Visa", "Ändra");
			projectNoteBox.SetData(project.ProjectJournal.Notes, "Note");

			SetEventMethods();
		}

		private void SetEventMethods()
		{
			projectParticipantBox.OnAdd += projectParticipantBox_OnAdd;
			projectParticipantBox.OnDoubleClickChoice += projectParticipantBox_OnDoubleClick;
			projectParticipantBox.OnGoTo += projectParticipantBox_OnGoTo;

			projectEventBox.OnAdd += projectEventBox_OnAdd;
			projectEventBox.OnDoubleClickChoice += projectEventBox_OnDoubleClick;
			projectEventBox.OnGoTo += projectEventBox_OnGoTo;

			projectNoteBox.OnAdd += projectNoteBox_OnAdd;
			projectNoteBox.OnDoubleClickChoice += projectNoteBox_OnDoubleClick;
			projectNoteBox.OnGoTo += projectNoteBox_OnGoTo;
		}

		private void projectNoteBox_OnGoTo(object sender, GoToHandlerEventArgs e)
		{
			// NotePopUp
		}

		private void projectNoteBox_OnDoubleClick(object sender, DoubleClickHandlerEventArgs e)
		{
			// NotePopUp
		}

		private void projectNoteBox_OnAdd()
		{
			CreateNoteForm createNoteForm = new CreateNoteForm(_project.ProjectJournal.Notes);
			createNoteForm.ShowDialog();
			MainForm.RefreshChoiceBox(projectNoteBox, _project.ProjectJournal.Notes, "Note");
		}

		private void projectEventBox_OnGoTo(object sender, GoToHandlerEventArgs e)
		{
			// EventPopUp
		}

		private void projectEventBox_OnDoubleClick(object sender, DoubleClickHandlerEventArgs e)
		{
			//EventPopUp
		}

		private void projectEventBox_OnAdd()
		{
			CreateEventForm createEventForm = new CreateEventForm(_project);
			createEventForm.ShowDialog();
			MainForm.RefreshChoiceBox(projectEventBox, _project.ProjectJournal.Events, "ProjectEvent");
		}

		private void projectParticipantBox_OnGoTo(object sender, GoToHandlerEventArgs e)
		{
			PersonPopUp personPopUp = new PersonPopUp((Person)e.ChosenItem, _companyManager, _projectManager);
			personPopUp.ShowDialog();
		}

		private void projectParticipantBox_OnDoubleClick(object sender, DoubleClickHandlerEventArgs e)
		{
			PersonPopUp personPopUp = new PersonPopUp((Person)e.ChosenItem, _companyManager, _projectManager);
			personPopUp.ShowDialog();
		}

		private void projectParticipantBox_OnAdd()
		{
			EditProjectParticipantListForm editParticipantList = new EditProjectParticipantListForm(_project, _companyManager);
			MainForm.RefreshChoiceBox(projectParticipantBox, _project.Roles, "Person");
		}
	}
}
