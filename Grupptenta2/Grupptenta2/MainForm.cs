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
			CompanyTabSetup();
			companySearchControl.SetHeader("Dina kundföretag");
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
			contactSearchControl.OnSearch += contactSearchControl_OnSearch;
			contactSearchControl.OnCreate += contactSearchControl_OnCreate;
			contactSearchControl.OnSelectionChanged += contactSearchControl_OnSelectionChanged;

			contactControl.OnSavePersonChanges += contactControl_OnSavePersonChanges;
			contactControl.OnDoubleClickNote += contactControl_OnDoubleClickNote;
			contactControl.OnClosePopUp += contactControl_OnClosePopUp;

			//Company
			companySearchControl.OnSearch += companySearchControl_OnSearch;
			companySearchControl.OnCreate += companySearchControl_OnCreate;
			companySearchControl.OnSelectionChanged += companySearchControl_OnSelectionChanged;

			companyControl.OnSaveCompanyChanges += companyControl_OnSaveCompanyChanges;
			companyControl.OnClosePopUp += companyControl_OnClosePopUp;

			companyProjectBox.OnAdd += companyProjectBox_OnAdd;
			companyProjectBox.OnGoTo += companyProjectBox_OnGoTo;
			companyProjectBox.OnDoubleClickChoice += companyProjectBox_OnDoubleClick;
			companyProjectBox.OnSelectionChanged += companyProjectBox_OnSelectionChanged;

			companyEmployeeBox.OnAdd += companyEmployeeBox_OnAdd;
			companyEmployeeBox.OnDoubleClickChoice += companyEmployeeBox_OnDoubleClick;
			companyEmployeeBox.OnGoTo += companyEmployeeBox_OnGoTo;
			companyEmployeeBox.OnSelectionChanged += companyEmployeeBox_OnSelectionChanged;

			// Project
			projectSearchControl.OnSearch += projectSearchBox_OnSearch;
			projectSearchControl.OnCreate += projectSearchControl_OnCreate;
			projectSearchControl.OnSelectionChanged += projectSearchControl_OnSelectionChanged;

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

		#region "Contacts"
		private void ContactTabSetup()
		{
			contactSearchControl.SetHeader("Dina kontakter");
			contactSearchControl.SetData(_personManager.Persons, "Name");
			contactProjectBox.SetHeader("Projekt");
			contactProjectBox.SetButtonTexts("Visa", "Lägg till");
			contactProjectBox.HideEditListBtn();
			contactRelationBox.SetHeader("Närstående");
			contactRelationBox.SetButtonTexts("Visa", "Lägg till");
		}
		private void contactSearchControl_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Person> searchResult = _personManager.Persons.Where(p => p.ToString().ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				contactSearchControl.SetData(searchResult, "Person");
		}
		private void contactSearchControl_OnCreate()
		{
			CreatePersonForm createPersonForm = new CreatePersonForm(_personManager, _companyManager);
			createPersonForm.ShowDialog();
			RefreshSearchBox(contactSearchControl, _personManager.Persons, "Person");
		}
		private void contactSearchControl_OnSelectionChanged(object sender, ChoiceBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedPerson = (Person)e.ChosenItem;
			LoadSelectedPerson();
		}

		private void contactControl_OnSavePersonChanges()
		{
			RefreshSearchBox(contactSearchControl, _personManager.Persons, "Person");
			this.Text = _selectedPerson.ToString();
		}
		private void contactControl_OnDoubleClickNote(object sender, DoubleClickNoteHandlerEventArgs e)
		{
			// Note popup(e.SelectedNote)
		}
		private void contactControl_OnClosePopUp()
		{
			RefreshSearchBox(contactSearchControl, _personManager.Persons, "Person");
			this.Text = _selectedPerson.ToString();
		}

		#endregion

		#region "Company"
		private void CompanyTabSetup()
		{
			companySearchControl.SetHeader("Dina kontakter");
			companySearchControl.SetData(_companyManager.Companies, "Name");
			companyProjectBox.SetHeader("Projekt");
			companyEmployeeBox.SetHeader("Kontakter");
			companyProjectBox.SetButtonTexts("Visa", "Skapa");
			companyEmployeeBox.SetButtonTexts("Visa", "Skapa");
		}
		// Company Container: Panel 1
		private void companySearchControl_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Company> searchResult = _companyManager.Companies.Where(c => c.Name.ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				companySearchControl.SetData(searchResult, "Name");
		}
		private void companySearchControl_OnCreate()
		{
			CreateCompanyForm createCompanyForm = new CreateCompanyForm(_companyManager);
			createCompanyForm.ShowDialog();
			RefreshSearchBox(companySearchControl, _companyManager.Companies, "Name");
		}
		private void companySearchControl_OnSelectionChanged(object sender, ChoiceBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedCompany = (Company)e.ChosenItem;
			this.Text = _selectedCompany.Name;
			companyControl.SetCompanyInfo(_selectedCompany);

			companyProjectBox.SetData(_selectedCompany.Projects, "Name");
			companyEmployeeBox.SetData(_selectedCompany.Employees, "Person");
		}

		// Company Container: Panel 2
		private void companyControl_OnSaveCompanyChanges()
		{
			RefreshSearchBox(companySearchControl, _companyManager.Companies, "Name");
			this.Text = _selectedCompany.Name;
		}
		private void companyControl_OnClosePopUp()
		{
			RefreshSearchBox(companySearchControl, _companyManager.Companies, "Name");
			this.Text = _selectedCompany.Name;
		}

		private void companyProjectBox_OnGoTo(object sender, GoToHandlerEventArgs e)
		{
			OpenProjectPopUp();
			RefreshChoiceBox(companyProjectBox, _selectedCompany.Projects, "Name");
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

		private void companyEmployeeBox_OnGoTo(object sender, GoToHandlerEventArgs e)
		{
			OpenPersonPopUp();
			RefreshChoiceBox(companyEmployeeBox, _selectedCompany.Employees, "Person");
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
			LoadSelectedProject();
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
		private void projectEventBox_OnGoTo(object sender, GoToHandlerEventArgs e)
		{
			// Ska fixa event-popup
		}
		#endregion


		public static void RefreshChoiceBox(ChoiceBox choiceBox, object dataSource, string displayMember)
		{
			choiceBox.SetData(dataSource, displayMember);
		}
		public static void RefreshSearchBox(SearchBox searchBox, object dataSource, string displayMember)
		{
			searchBox.SetData(dataSource, displayMember);
		}
		private void OpenPersonPopUp()
		{
			PersonPopUp personPopUp = new PersonPopUp(_selectedPerson, _companyManager, _projectManager);
			personPopUp.ShowDialog();
		}
		private void OpenCompanyPopUp()
		{
			CompanyPopUp companyPopUp = new CompanyPopUp(_selectedCompany);
			companyPopUp.ShowDialog();
			RefreshSearchBox(companySearchControl, _companyManager.Companies, "Name");
		}
		private void OpenProjectPopUp()
		{
			ProjectPopUp projectPopUp = new ProjectPopUp(_selectedProject, _companyManager, _projectManager);
			projectPopUp.ShowDialog();
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

        private void projectParticipantBox_Load(object sender, EventArgs e)
        {

        }
	}
}
