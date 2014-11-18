﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestClasses;
using CodeBase;

namespace Grupptenta2
{
	public partial class MainForm : Form
	{
		private static PersonManager _personManager;
		private static CompanyManager _companyManager;
		private static ProjectManager _projectManager;
		private static Person _selectedPerson;
		private static Company _selectedCompany;
		private static Project _selectedProject;

		public MainForm()
		{
			_personManager = new PersonManager();
			_companyManager = new CompanyManager();
			_projectManager = new ProjectManager();

			InitializeComponent();

			//CreateMocks();
			//SaveDataXml.SaveCompanies(_companyManager.Companies);
			//SaveDataXml.SavePersons(_personManager.Persons);
			//SaveDataXml.SaveProjects(_projectManager.Projects);

			SetEventMethods();
			ProjectTabSetup();
			ContactTabSetup();
			CompanyTabSetup();
		}

		private static void CreateMocks()
		{
			int numberOfCompanies = 3;
			int numberOfPersons = 12;
			int numberOfProjects = 6;

			for (int i = 0; i < numberOfCompanies; i++)
			{
				_companyManager.CreateCompany("Company no." + (i + 1));
			}

			for (int i = 0; i < numberOfPersons; i++)
			{
				_personManager.CreatePerson("Per" + (i + 1));
				_personManager.Persons[i].LastName = "Persson" + (i + 1);
				_personManager.Persons[i].Birthdate = DateTime.Today.AddYears(-(i + 1));
				_personManager.Persons[i].EmailAddress = "Per" + (i + 1) + "@" + "Persson" + (i + 1) + ".com";
			}

			for (int i = 0; i < numberOfProjects; i++)
			{
				_projectManager.CreateProject("Project no." + (i + 1));
				_projectManager.Projects[i].Name = "Project no." + (i + 1);
				_projectManager.Projects[i].ProjectJournal = new Journal();
			}

			_companyManager.Companies[0].Employees.Add(_personManager.Persons[0]);
			_companyManager.Companies[0].Employees.Add(_personManager.Persons[1]);
			_companyManager.Companies[0].Employees.Add(_personManager.Persons[2]);
			_companyManager.Companies[0].Employees.Add(_personManager.Persons[3]);
			_companyManager.Companies[1].Employees.Add(_personManager.Persons[4]);
			_companyManager.Companies[1].Employees.Add(_personManager.Persons[5]);
			_companyManager.Companies[1].Employees.Add(_personManager.Persons[6]);
			_companyManager.Companies[1].Employees.Add(_personManager.Persons[7]);
			_companyManager.Companies[2].Employees.Add(_personManager.Persons[8]);
			_companyManager.Companies[2].Employees.Add(_personManager.Persons[9]);
			_companyManager.Companies[2].Employees.Add(_personManager.Persons[10]);
			_companyManager.Companies[2].Employees.Add(_personManager.Persons[11]);

			_companyManager.Companies[0].Projects.Add(_projectManager.Projects[0]);
			_companyManager.Companies[0].Projects[0].Roles.Add(_personManager.Persons[0]);
			_companyManager.Companies[0].Projects[0].Roles.Add(_personManager.Persons[1]);

			_companyManager.Companies[0].Projects.Add(_projectManager.Projects[1]);
			_companyManager.Companies[0].Projects[1].Roles.Add(_personManager.Persons[2]);
			_companyManager.Companies[0].Projects[1].Roles.Add(_personManager.Persons[3]);

			_companyManager.Companies[1].Projects.Add(_projectManager.Projects[2]);
			_companyManager.Companies[1].Projects[0].Roles.Add(_personManager.Persons[4]);
			_companyManager.Companies[1].Projects[0].Roles.Add(_personManager.Persons[5]);

			_companyManager.Companies[1].Projects.Add(_projectManager.Projects[3]);
			_companyManager.Companies[1].Projects[1].Roles.Add(_personManager.Persons[6]);
			_companyManager.Companies[1].Projects[1].Roles.Add(_personManager.Persons[7]);

			_companyManager.Companies[2].Projects.Add(_projectManager.Projects[4]);
			_companyManager.Companies[2].Projects[0].Roles.Add(_personManager.Persons[8]);
			_companyManager.Companies[2].Projects[0].Roles.Add(_personManager.Persons[9]);

			_companyManager.Companies[2].Projects.Add(_projectManager.Projects[5]);
			_companyManager.Companies[2].Projects[1].Roles.Add(_personManager.Persons[10]);
			_companyManager.Companies[2].Projects[1].Roles.Add(_personManager.Persons[11]);
		}

		private void SetEventMethods()
		{
			// Contact
			contactChoiceBox.OnAdd += contactChoiceBox_OnAdd;
			contactChoiceBox.OnSelectionChanged += contactChoiceBox_OnSelectionChanged;

			contactControl.OnSavePersonChanges += contactControl_OnSavePersonChanges;
			contactControl.OnDoubleClickNote += contactControl_OnDoubleClickNote;

			contactRelationBox.OnAdd += contactRelationBox_OnAdd;
			contactRelationBox.OnDoubleClickChoice += contactRelationBox_OnDoubleClickChoice;
			contactRelationBox.OnSelectionChanged += contactRelationBox_OnSelectionChanged;

			contactProjectBox.OnDoubleClickChoice += contactProjectBox_OnDoubleClickChoice;
			contactProjectBox.OnSelectionChanged += contactProjectBox_OnSelectionChanged;
			contactProjectBox.OnAdd += contactProjectBox_OnAdd;

			//Company
			companyChoiceBox.OnSelectionChanged += companyChoiceBox_OnSelectionChanged;
			companyChoiceBox.OnAdd += companyChoiceBox_OnAdd;

			companyControl.OnSaveCompanyChanges += companyControl_OnSaveCompanyChanges;

			companyProjectBox.OnAdd += companyProjectBox_OnAdd;
			companyProjectBox.OnDoubleClickChoice += companyProjectBox_OnDoubleClick;
			companyProjectBox.OnSelectionChanged += companyProjectBox_OnSelectionChanged;

			companyEmployeeBox.OnAdd += companyEmployeeBox_OnAdd;
			companyEmployeeBox.OnDoubleClickChoice += companyEmployeeBox_OnDoubleClick;
			companyEmployeeBox.OnSelectionChanged += companyEmployeeBox_OnSelectionChanged;

			// Project
			projectChoiceBox.OnAdd += projectChoiceBox_OnAdd;
			projectChoiceBox.OnSelectionChanged += projectChoiceBox_OnSelectionChanged;

			projectParticipantBox.OnAdd += projectParticipantBox_OnAdd;
			projectParticipantBox.OnDoubleClickChoice += projectParticipantBox_OnDoubleClickChoice;
			projectParticipantBox.OnSelectionChanged += projectParticipantBox_OnSelectionChanged;

			projectEventBox.OnAdd += projectEventBox_OnAdd;
			projectEventBox.OnDoubleClickChoice += projectEventBox_OnDoubleClickChoice;

			projectNoteBox.OnAdd += projectNoteBox_OnAdd;
			projectNoteBox.OnDoubleClickChoice += projectNoteBox_OnDoubleClickChoice;
		}

		private void logOutBtn_Click(object sender, EventArgs e)
		{
			SaveDataXml.SaveCompanies(_companyManager.Companies);
			SaveDataXml.SavePersons(_personManager.Persons);
			SaveDataXml.SaveProjects(_projectManager.Projects);
			this.Close();
		}
		private void quitBtn_Click(object sender, EventArgs e)
		{
			SaveDataXml.SaveCompanies(_companyManager.Companies);
			SaveDataXml.SavePersons(_personManager.Persons);
			SaveDataXml.SaveProjects(_projectManager.Projects);
			Application.Exit();
		}

		#region "Contacts"
		private void ContactTabSetup()
		{
			contactChoiceBox.SetHeader("Dina kontakter");
			contactChoiceBox.SetData(_personManager.Persons, "Name");
			contactChoiceBox.SetButtonTexts("Ny kontakt");

			contactProjectBox.SetHeader("Projekt");
			contactProjectBox.SetButtonTexts("Nytt projekt");

			contactRelationBox.SetHeader("Närstående");
			contactRelationBox.SetButtonTexts("Lägg till");
		}
		// Contact Container: Panel 1
		private void contactChoiceBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedPerson = (Person)e.ChosenItem;
            if (_selectedPerson != null)
            {
                LoadSelectedPerson(); 
            }
		}
		private void contactChoiceBox_OnAdd()
		{
			CreatePersonForm createPersonForm = new CreatePersonForm(_personManager, _companyManager);
			createPersonForm.ShowDialog();
		}

		// Contact Container: Panel 2
		private void contactControl_OnSavePersonChanges()
		{
			this.Text = _selectedPerson.ToString();
		}
		private void contactControl_OnDoubleClickNote(object sender, DoubleClickNoteHandlerEventArgs e)
		{
			NoteForm noteForm = new NoteForm(e.SelectedNote);
			noteForm.ShowDialog();
		}

		private void contactProjectBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedProject = (Project)e.ChosenItem;
		}
		private void contactProjectBox_OnDoubleClickChoice(object sender, DoubleClickHandlerEventArgs e)
		{
			tabControl.SelectedIndex = 2;
			LoadSelectedProject();
		}
		private void contactProjectBox_OnAdd()
		{
			CreateProjectForm createProjectform = new CreateProjectForm(_selectedPerson, _projectManager, _personManager, _companyManager);
			createProjectform.ShowDialog();
			RefreshChoiceBox(contactProjectBox, _projectManager.Projects.Where(p => p.Roles.Any(r => r.Id == _selectedPerson.Id)).ToList(), "Name");
		}

		private void contactRelationBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedPerson = (Person)e.ChosenItem;
		}
		private void contactRelationBox_OnDoubleClickChoice(object sender, DoubleClickHandlerEventArgs e)
		{
			tabControl.SelectedIndex = 3;
			LoadSelectedPerson();
		}
		private void contactRelationBox_OnAdd()
		{
			CreatePersonForm createRelationForm = new CreatePersonForm(true, _selectedPerson, _personManager);
			createRelationForm.ShowDialog();
			RefreshChoiceBox(contactRelationBox, _selectedPerson.Relations, "Person");
		}

		#endregion

		#region "Company"
		private void CompanyTabSetup()
		{
			companyChoiceBox.SetHeader("Dina kundföretag");
			companyChoiceBox.SetData(_companyManager.Companies, "Name");
			companyChoiceBox.SetButtonTexts("Nytt företag");
			
			companyProjectBox.SetHeader("Projekt");
			companyProjectBox.SetButtonTexts("Skapa");

			companyEmployeeBox.SetHeader("Kontakter");
			companyEmployeeBox.SetButtonTexts("Skapa");
		}
		// Company Container: Panel 1
		private void companyChoiceBox_OnAdd()
		{
			CreateCompanyForm createCompanyForm = new CreateCompanyForm(_companyManager);
			createCompanyForm.ShowDialog();
		}
		private void companyChoiceBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedCompany = (Company)e.ChosenItem;
                        if (_selectedCompany != null)
            {
                LoadSelectedCompany(); 
            }
		}

		// Company Container: Panel 2
		private void companyControl_OnSaveCompanyChanges()
		{
			this.Text = _selectedCompany.Name;
		}

		private void companyProjectBox_OnAdd()
		{
			CreateProjectForm createProjectForm = new CreateProjectForm(_selectedCompany, _projectManager, _personManager, _companyManager);
			createProjectForm.ShowDialog();
			RefreshChoiceBox(companyProjectBox, _selectedCompany.Projects, "Name");
		}
		private void companyProjectBox_OnDoubleClick(object sender, DoubleClickHandlerEventArgs e)
		{
			tabControl.SelectedIndex = 2;
			LoadSelectedProject();
		}
		private void companyProjectBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedProject = (Project)e.ChosenItem;
		}

		private void companyEmployeeBox_OnDoubleClick(object sender, DoubleClickHandlerEventArgs e)
		{
			tabControl.SelectedIndex = 3;
			LoadSelectedPerson();
		}
		private void companyEmployeeBox_OnAdd()
		{
			CreatePersonForm createPersonForm = new CreatePersonForm(_selectedCompany, _personManager, _companyManager);
			createPersonForm.ShowDialog();
			RefreshChoiceBox(companyEmployeeBox, _selectedCompany.Employees, "Person");
		}
		private void companyEmployeeBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedPerson = (Person)e.ChosenItem;
		}
		#endregion

		#region "Project"
		private void ProjectTabSetup()
		{
			projectChoiceBox.SetHeader("Dina projekt");
			projectChoiceBox.SetData(_projectManager.Projects, "Name");
			projectChoiceBox.SetButtonTexts("Nytt projekt");

			projectParticipantBox.SetHeader("Deltagare");

			projectEventBox.SetHeader("Händelser");
			projectEventBox.SetButtonTexts("Lägg till");

			projectNoteBox.SetHeader("Anteckningar");
			projectNoteBox.SetButtonTexts("Lägg till");
		}
		// Project Container: Panel 1
		private void projectChoiceBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedProject = (Project)e.ChosenItem;
            if (_selectedProject != null)
            {
                LoadSelectedProject(); 
            }
		}

		private void projectChoiceBox_OnAdd()
		{
			CreateProjectForm createProjectForm = new CreateProjectForm(_projectManager, _personManager, _companyManager);
			createProjectForm.Show();
			RefreshChoiceBox(projectChoiceBox, _projectManager.Projects, "Name");
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			_selectedProject.Name = projectNameBox.Text;
			_selectedProject.Description = projectDescBox.Text;
		}
		
		// Project Container: Panel 2
		private void projectParticipantBox_OnAdd()
		{
			EditParticipantListForm editParticipantListForm = new EditParticipantListForm(_selectedProject, _companyManager.Companies.SingleOrDefault(c => c.Projects.Any(p => p.Id == _selectedProject.Id)));
			editParticipantListForm.ShowDialog();
			projectParticipantBox.SetData(_selectedProject.Roles, "Person");
		}
		private void projectParticipantBox_OnSelectionChanged(object sender, ListBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedPerson = (Person)e.ChosenItem;
		}
		private void projectParticipantBox_OnDoubleClickChoice(object sender, DoubleClickHandlerEventArgs e)
		{
			tabControl.SelectedIndex = 3;
			LoadSelectedPerson();
		}

		private void projectNoteBox_OnAdd()
		{
			CreateNoteForm createNoteForm = new CreateNoteForm(_selectedProject.Notes);
			createNoteForm.ShowDialog();
			RefreshChoiceBox(projectNoteBox, _selectedProject.Notes, "Note");
		}

		private void projectNoteBox_OnDoubleClickChoice(object sender, DoubleClickHandlerEventArgs e)
		{
			Note noteToEdit = (Note)projectNoteBox.listBox.SelectedItem;
			CreateNoteForm createNoteForm = new CreateNoteForm(noteToEdit);
			createNoteForm.ShowDialog();
			RefreshChoiceBox(projectNoteBox, _selectedProject.Notes, "Note");
		}

		private void projectEventBox_OnAdd()
		{
			CreateEventForm createEventForm = new CreateEventForm(_selectedProject);
			createEventForm.ShowDialog();
			RefreshChoiceBox(projectEventBox, _selectedProject.ProjectJournal.Events, "ProjectEvent");
		}
		private void projectEventBox_OnDoubleClickChoice(object sender, DoubleClickHandlerEventArgs e)
		{
			throw new NotImplementedException();
		}
		#endregion


		public static void RefreshChoiceBox(ChoiceBox choiceBox, object dataSource, string displayMember)
		{
			choiceBox.SetData(dataSource, displayMember);
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Text = tabControl.SelectedTab.Text;
		}
		private void LoadSelectedProject()
		{
			this.Text = _selectedProject.Name;
			projectNameBox.Text = _selectedProject.Name;
			projectIdBox.Text = _selectedProject.Id.ToString();
			projectCompanyBox.Text = _companyManager.Companies.SingleOrDefault(c => c.Projects.Any(p => p.Id == _selectedProject.Id)).Name;
			projectDescBox.Text = _selectedProject.Description;

			projectParticipantBox.SetData(_selectedProject.Roles, "Person");
			projectEventBox.SetData(_selectedProject.ProjectJournal.Events, "ProjectEvent");
			projectNoteBox.SetData(_selectedProject.ProjectJournal.Notes, "Note");
			RefreshChoiceBox(projectNoteBox, _selectedProject.Notes, "Note");
		}
		private void LoadSelectedPerson()
		{
			List<Project> projects = _projectManager.Projects.Where(p => p.Roles.Any(r => r.Id == _selectedPerson.Id)).ToList();

			this.Text = _selectedPerson.ToString();
			contactControl.SetPersonInfo(_selectedPerson, _companyManager, _projectManager);
			contactProjectBox.SetData(projects, "Name");
			contactRelationBox.SetData(_selectedPerson.Relations, "Person");
		}
		private void LoadSelectedCompany()
		{
			this.Text = _selectedCompany.Name;
			companyControl.SetCompanyInfo(_selectedCompany);
			companyProjectBox.SetData(_selectedCompany.Projects, "Name");
			companyEmployeeBox.SetData(_selectedCompany.Employees, "Person");
		}
	}
}
