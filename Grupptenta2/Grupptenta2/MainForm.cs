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
using CodeBase;

namespace Grupptenta2
{
	public partial class MainForm : Form
	{
		private static PersonManager _personManager;
		private static CompanyManager _companyManager;
		private static ProjectManager _projectManager;
		private Person _selectedPerson;
		private Company _selectedCompany;
		private Project _selectedProject;

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
			projectSearchControl.SetHeader("Dina projekt");
			ContactTabSetup();
			contactSearchControl.SetHeader("Dina kontakter");
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
			contactSearchControl.OnSearch += personSearchBox_OnSearch;
			contactSearchControl.OnGoToChoice += personSearchBox_OnGoToChoice;
			contactSearchControl.OnCreate += personSearchBox_OnCreate;
			contactSearchControl.OnSelectionChanged += personSearchBox_OnSelectionChanged;
			contactSearchControl.OnDoubleClickChoice += personSearchBox_OnDoubleClickChoice;

			contactControl.OnSavePersonChanges += personControl_OnSavePersonChanges;
			contactControl.OnClosePopUp += personControl_OnClosePopUp;

			companySearchControl.OnSearch += companySearchBox_OnSearch;
			companySearchControl.OnGoToChoice += companySearchBox_OnGoToChoice;
			companySearchControl.OnCreate += companySearchControl_OnCreate;
			companySearchControl.OnSelectionChanged += companySearchBox_OnSelectionChanged;
			companySearchControl.OnDoubleClickChoice += companySearchBox_OnDoubleClickChoice;

			companyControl.OnSaveCompanyChanges += companyControl_OnSaveCompanyChanges;
			companyControl.OnClosePopUp += companyControl_OnClosePopUp;

			projectSearchControl.OnSearch += projectSearchBox_OnSearch;
			projectSearchControl.OnGoToChoice += projectSearchBox_OnGoToChoice;
			projectSearchControl.OnCreate += projectSearchControl_OnCreate;
			projectSearchControl.OnSelectionChanged += projectSearchControl_OnSelectionChanged;
			projectSearchControl.OnDoubleClickChoice += projectSearchControl_OnDoubleClickChoice;

			projectParticipantBox.OnGoTo += projectParticipantBox_OnGoTo;
			projectParticipantBox.OnAdd += projectParticipantBox_OnAdd;
			projectEventBox.OnGoTo += projectEventBox_OnGoTo;
			projectEventBox.OnAdd += projectEventBox_OnAdd;
			projectNoteBox.OnGoTo += projectNoteBox_OnGoTo;
			projectNoteBox.OnAdd += projectNoteBox_OnAdd;
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

		//private void clientBtn_Click(object sender, EventArgs e)
		//{
		//	this.Text = "Dina företagskunder";
		//	this.companySearchControl.Location = new System.Drawing.Point(210, 10);
		//	companySearchControl.SetData(_companyManager.Companies, "Name");
		//}

		private void profileBtn_Click(object sender, EventArgs e)
		{
			this.Text = "Din profil";
		}
		private void calendarBtn_Click(object sender, EventArgs e)
		{
			this.Text = "Kalender";
		}

		#region "Contacts"
		private void ContactTabSetup()
		{
			contactSearchControl.SetHeader("Dina kontakter");
			contactSearchControl.SetData(_personManager.Persons, "Name");
			contactProjectBox.SetHeader("Projekt");
			contactRelationBox.SetHeader("Närstående");
			contactProjectBox.SetButtonTexts("Visa", "Lägg till");
			contactRelationBox.SetButtonTexts("Visa", "Lägg till");
		}
		private void personSearchBox_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Person> searchResult = _personManager.Persons.Where(p => p.ToString().ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				contactSearchControl.SetData(searchResult, "Person");
		}
		private void personSearchBox_OnGoToChoice(object sender, GoToChoiceHandlerEventArgs e)
		{
			List<Project> projects = _projectManager.Projects.Where(p => p.Roles.Any(r => r.Id == _selectedPerson.Id)).ToList();

			this.Text = _selectedPerson.ToString();
			contactControl.SetPersonInfo(_selectedPerson, _companyManager, _projectManager);

			contactProjectBox.SetData(projects, "Name");
			contactRelationBox.SetData(_selectedPerson.Relations, "Person");
		}
		private void personSearchBox_OnCreate()
		{
			CreatePersonForm createPersonForm = new CreatePersonForm(_personManager, _companyManager);
			createPersonForm.ShowDialog();
			RefreshSearchBox(contactSearchControl, _personManager.Persons, "Person");
		}
		private void personSearchBox_OnDoubleClickChoice(object sender, DoubleClickChoiceHandlerEventArgs e)
		{
			PersonPopUp personPopUp = new PersonPopUp(_selectedPerson, _companyManager, _projectManager);
			personPopUp.ShowDialog();
			RefreshSearchBox(contactSearchControl, _personManager.Persons, "Person");
		}
		private void personSearchBox_OnSelectionChanged(object sender, ChoiceBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedPerson = (Person)e.ChosenItem;
		}
		private void personControl_OnSavePersonChanges()
		{
			RefreshSearchBox(contactSearchControl, _personManager.Persons, "Person");
			this.Text = _selectedPerson.ToString();
		}
		private void personControl_OnClosePopUp()
		{
			RefreshSearchBox(contactSearchControl, _personManager.Persons, "Person");
			this.Text = _selectedPerson.ToString();
		}

		#endregion

		#region "Company"
		private void companySearchBox_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Company> searchResult = _companyManager.Companies.Where(c => c.Name.ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				companySearchControl.SetData(searchResult, "Name");
		}
		private void companySearchBox_OnGoToChoice(object sender, GoToChoiceHandlerEventArgs e)
		{
			this.Text = _selectedCompany.Name;
			companyControl.Visible = true;
			companyControl.SetCompanyInfo(_selectedCompany);
			this.companyControl.Location = new System.Drawing.Point(210, 10);
		}
		private void companySearchControl_OnCreate()
		{
			CreateCompanyForm createCompanyForm = new CreateCompanyForm(_companyManager);
			createCompanyForm.ShowDialog();
			RefreshSearchBox(companySearchControl, _companyManager.Companies, "Name");
		}
		private void companySearchBox_OnSelectionChanged(object sender, ChoiceBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedCompany = (Company)e.ChosenItem;
		}
		private void companySearchBox_OnDoubleClickChoice(object sender, DoubleClickChoiceHandlerEventArgs e)
		{
			CompanyPopUp companyPopUp = new CompanyPopUp(_selectedCompany);
			companyPopUp.ShowDialog();
			RefreshSearchBox(companySearchControl, _companyManager.Companies, "Name");
		}
		private void companyControl_OnSaveCompanyChanges(object sender, SaveCompanyChangesHandlerEventArgs e)
		{
			_selectedCompany.Name = e.Name;
			_selectedCompany.Id = e.Id;
			_selectedCompany.Location.Street = e.Street;
			_selectedCompany.Location.ZipCode = e.ZipCode;
			_selectedCompany.Location.City = e.City;
			_selectedCompany.IsActive = e.IsActive;

			RefreshSearchBox(companySearchControl, _companyManager.Companies, "Name");
			this.Text = _selectedCompany.Name;
		}
		private void companyControl_OnClosePopUp()
		{
			RefreshSearchBox(companySearchControl, _companyManager.Companies, "Name");
			this.Text = _selectedCompany.Name;
		}
		#endregion

		#region "Project"
		private void ProjectTabSetup()
		{
			projectSearchControl.SetHeader("Dina Project");
			projectSearchControl.SetData(_projectManager.Projects, "Name");
			projectParticipantBox.SetHeader("Deltagare");
			projectEventBox.SetHeader("Händelser");
			projectNoteBox.SetHeader("Anteckningar");
			projectEventBox.SetButtonTexts("Öppna", "Lägg till");
			projectNoteBox.SetButtonTexts("Öppna", "Lägg till");
		}
		private void projectSearchBox_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Project> searchResult = _projectManager.Projects.Where(p => p.Name.ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				projectSearchControl.SetData(searchResult, "Name");
		}
		private void projectSearchBox_OnGoToChoice(object sender, GoToChoiceHandlerEventArgs e)
		{
			this.Text = _selectedProject.Name;
			projectNameBox.Text = _selectedProject.Name;
			projectIdBox.Text = _selectedProject.Id.ToString();
			projectCompanyBox.Text = _companyManager.Companies.SingleOrDefault(c => c.Projects.Any(p => p.Id == _selectedProject.Id)).Name;
			projectDescBox.Text = _selectedProject.Description;

			projectParticipantBox.SetData(_selectedProject.Roles, "Person");
			projectEventBox.SetData(_selectedProject.ProjectJournal.Events, "ProjectEvent");
			projectNoteBox.SetData(_selectedProject.ProjectJournal.Notes, "Note");
		}
		private void saveBtn_Click(object sender, EventArgs e)
		{
			_selectedProject.Name = projectNameBox.Text;
			_selectedProject.Description = projectDescBox.Text;
		}
		private void projectSearchControl_OnCreate()
		{
			CreateProjectForm createProjectForm = new CreateProjectForm(_projectManager, _personManager, _companyManager);
			createProjectForm.Show();
			RefreshSearchBox(projectSearchControl, _projectManager.Projects, "Name");
		}
		private void projectSearchControl_OnSelectionChanged(object sender, ChoiceBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedProject = (Project)e.ChosenItem;
		}
		private void projectSearchControl_OnDoubleClickChoice(object sender, DoubleClickChoiceHandlerEventArgs e)
		{
			// Ska fixa projekt-popup.
		}
		private void projectParticipantBox_OnAdd()
		{
			EditParticipantListForm editParticipantListForm = new EditParticipantListForm(_selectedProject, _companyManager.Companies.SingleOrDefault(c => c.Projects.Any(p => p.Id == _selectedProject.Id)));
			editParticipantListForm.ShowDialog();
			projectParticipantBox.SetData(_selectedProject.Roles, "Person");
		}
		private void projectParticipantBox_OnGoTo(object sender, GoToHandlerEventArgs e)
		{
			// Ska fixa person-popup.
		}
		private void projectNoteBox_OnAdd()
		{
			CreateNoteForm createNoteForm = new CreateNoteForm(_selectedProject.Notes);
			createNoteForm.ShowDialog();
			RefreshChoiceBox(projectNoteBox, _selectedProject.Notes, "Note");
		}
		private void projectNoteBox_OnGoTo(object sender, GoToHandlerEventArgs e)
		{
			// Ska fixa note-popup
		}
		private void projectEventBox_OnAdd()
		{
			CreateEventForm createEventForm = new CreateEventForm(_selectedProject);
			createEventForm.ShowDialog();
			RefreshChoiceBox(projectEventBox, _selectedProject.ProjectJournal.Events, "ProjectEvent");
		}
		private void projectEventBox_OnGoTo(object sender, GoToHandlerEventArgs e)
		{
			// Ska fixa event-popup
		}
		#endregion

		private void RefreshChoiceBox(ChoiceBox choiceBox, object dataSource, string displayMember)
		{
			choiceBox.SetData(dataSource, displayMember);
		}

		private void RefreshSearchBox(SearchBox searchBox, object dataSource, string displayMember)
		{
			searchBox.SetData(dataSource, displayMember);
		}
		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Text = tabControl.SelectedTab.Text;
		}
	}
}
