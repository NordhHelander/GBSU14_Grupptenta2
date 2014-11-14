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
		private static List<Panel> _panels = new List<Panel>();
		private static List<UserControl> _userControls = new List<UserControl>();
		private static PersonManager _personManager = new PersonManager();
		private static CompanyManager _companyManager = new CompanyManager();
		private static ProjectManager _projectManager = new ProjectManager();
		private Person _selectedPerson;
		private Company _selectedCompany;

		public MainForm()
		{
			InitializeComponent();
			this.ClientSize = new Size(1100, 675);
            //CreateMocks();
            //SaveDataXml.SaveCompanies(_companyManager._companies);
            //SaveDataXml.SavePersons(_personManager._persons);
			LoadPanelsList();
			HidePanels();

			LoadUserControlList();
			HideUserControls();

			SetEventMethods();

		}

		private void SetEventMethods()
		{
			personSearchControl.OnGoToChoice += personSearchBox_OnGoToChoice;
			personSearchControl.OnSearch += personSearchBox_OnSearch;
			personSearchControl.OnCreate += personSearchBox_OnCreate;
			personSearchControl.OnDoubleClickChoice += personSearchBox_OnDoubleClickChoice;
			personSearchControl.OnSelectionChanged += personSearchBox_OnSelectionChanged;

			companySearchControl.OnGoToChoice += clientSearchBox_OnGoToChoice;
			companySearchControl.OnSearch += clientSearchBox_OnSearch;
			companySearchControl.OnCreate += companySearchControl_OnCreate;
			companySearchControl.OnSelectionChanged += clientSearchBox_OnSelectionChanged;
			companySearchControl.OnDoubleClickChoice += clientSearchBox_OnDoubleClickChoice;

			projectSearchControl.OnGoToChoice += projectSearchBox_OnGoToChoice;
			projectSearchControl.OnSearch += projectSearchBox_OnSearch;
			personPnlInfoBox.OnSaveChanges += personPnlInfoBox_OnSaveChanges;

			companyControl.OnSaveCompanyChanges += companyUserForm_OnSaveCompanyChanges;
			companyControl.OnClosePopUp += companyUserForm_OnClosePopUp;
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
				_personManager.GetPersons()[i].LastName = "Persson" + (i + 1);
				_personManager.GetPersons()[i].Birthdate = DateTime.Today.AddYears(-(i + 1));
				_personManager.GetPersons()[i].EmailAddress = "Per" + (i + 1) + "@" + "Persson" + (i + 1) + ".com";
			}

			for (int i = 0; i < numberOfProjects; i++)
			{
				//_projectManager.CreateProject();
				_projectManager.GetProjects()[i].Name = "Project no." + (i + 1);
				_projectManager.GetProjects()[i].ProjectJournal = new Journal();
			}

			_companyManager.GetCompanies()[0].Employees.Add(_personManager.GetPersons()[0]);
			_companyManager.GetCompanies()[0].Employees.Add(_personManager.GetPersons()[1]);
			_companyManager.GetCompanies()[0].Employees.Add(_personManager.GetPersons()[2]);
			_companyManager.GetCompanies()[0].Employees.Add(_personManager.GetPersons()[3]);
			_companyManager.GetCompanies()[1].Employees.Add(_personManager.GetPersons()[4]);
			_companyManager.GetCompanies()[1].Employees.Add(_personManager.GetPersons()[5]);
			_companyManager.GetCompanies()[1].Employees.Add(_personManager.GetPersons()[6]);
			_companyManager.GetCompanies()[1].Employees.Add(_personManager.GetPersons()[7]);
			_companyManager.GetCompanies()[2].Employees.Add(_personManager.GetPersons()[8]);
			_companyManager.GetCompanies()[2].Employees.Add(_personManager.GetPersons()[9]);
			_companyManager.GetCompanies()[2].Employees.Add(_personManager.GetPersons()[10]);
			_companyManager.GetCompanies()[2].Employees.Add(_personManager.GetPersons()[11]);

			_companyManager.GetCompanies()[0].Projects.Add(_projectManager.GetProjects()[0]);
			_companyManager.GetCompanies()[0].Projects.Add(_projectManager.GetProjects()[1]);
			_companyManager.GetCompanies()[1].Projects.Add(_projectManager.GetProjects()[2]);
			_companyManager.GetCompanies()[1].Projects.Add(_projectManager.GetProjects()[3]);
			_companyManager.GetCompanies()[2].Projects.Add(_projectManager.GetProjects()[4]);
			_companyManager.GetCompanies()[2].Projects.Add(_projectManager.GetProjects()[5]);
		}

		#region "Panel Control"
		private void LoadPanelsList()
		{
			_panels.Add(personPnl);
			_panels.Add(projectPnl);
			_panels.Add(clientPnl);
			_panels.Add(profilePnl);
		}
		private void LoadUserControlList()
		{
			_userControls.Add(projectSearchControl);
			_userControls.Add(personSearchControl);
			_userControls.Add(companySearchControl);
			_userControls.Add(companyControl);
		}
		private void SwitchPanel(Panel panel)
		{
			panel.Visible = true;
			HideAllPanelsExceptThis(panel);
			HideUserControls();
		}
		private void HideAllPanelsExceptThis(Panel currentPanel)
		{
			foreach (Panel panel in _panels)
			{
				if (panel != currentPanel)
				{
					panel.Visible = false;
				}
			}
		}
		private void HidePanels()
		{
			foreach (Panel panel in _panels)
			{
				panel.Visible = false;
			}
		}
		private void HideUserControls()
		{
			foreach (var userControl in _userControls)
			{
				userControl.Visible = false;
			}
		}

		#endregion

		#region "Main Menu Items"
		private void logOutBtn_Click(object sender, EventArgs e)
		{
            SaveDataXml.SaveCompanies(_companyManager._companies);
            SaveDataXml.SavePersons(_personManager._persons);
            SaveDataXml.SaveProjects(_projectManager._projects);
            this.Close();
		}
		private void quitBtn_Click(object sender, EventArgs e)
		{
            SaveDataXml.SaveCompanies(_companyManager._companies);
            SaveDataXml.SavePersons(_personManager._persons);
            SaveDataXml.SaveProjects(_projectManager._projects);
            Application.Exit();
		}
		private void profileBtn_Click(object sender, EventArgs e)
		{
			this.Text = "Din profil";
		}
		private void calendarBtn_Click(object sender, EventArgs e)
		{
			this.Text = "Kalender";
			//SwitchPanel(calendarPnl);
			//this.calendarPnl.Location = new System.Drawing.Point(200, 0);
		}
		private void projectBtn_Click(object sender, EventArgs e)
		{
			this.Text = "Dina projekt";
			HidePanels();
			HideUserControls();
			projectSearchControl.Visible = true;
			this.projectSearchControl.Location = new System.Drawing.Point(210, 10);
			projectSearchControl.BindListBoxData(_projectManager.GetProjects(), "Name");
		}
		private void clientBtn_Click(object sender, EventArgs e)
		{
			this.Text = "Dina företagskunder";
			HidePanels();
			HideUserControls();
			companySearchControl.Visible = true;
			this.companySearchControl.Location = new System.Drawing.Point(210, 10);
			companySearchControl.BindListBoxData(_companyManager.GetCompanies(), "Name");
		}
		private void contactsBtn_Click(object sender, EventArgs e)
		{
			this.Text = "Dina kontakter";
			HidePanels();
			HideUserControls();
			personSearchControl.Visible = true;
			this.personSearchControl.Location = new System.Drawing.Point(210, 10);
			personSearchControl.BindListBoxData(_personManager.GetPersons(), "Person");
		}
		#endregion

		#region "Person"
		// choosePersonPnl
		private void personSearchBox_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Person> searchResult = _personManager.GetPersons().Where(p => p.ToString().ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				personSearchControl.BindListBoxData(searchResult, "Person");
		}

		private void personSearchBox_OnGoToChoice(object sender, GoToChoiceHandlerEventArgs e)
		{
			this.Text = _selectedPerson.ToString();
			SwitchPanel(personPnl);
			this.personPnl.Location = new System.Drawing.Point(200, 0);
			LoadPersonPnl();
		}

		private void personSearchBox_OnCreate()
		{
			CreatePersonForm createPersonForm = new CreatePersonForm(_personManager, _companyManager);
			createPersonForm.ShowDialog();
		}

		private void personSearchBox_OnDoubleClickChoice(object sender, DoubleClickChoiceHandlerEventArgs e)
		{
			PersonPopUp personPopUp = new PersonPopUp((Person)e.ChosenItem, _companyManager, _projectManager);
			personPopUp.ShowDialog();
			RefreshPersonSearchBox();
		}

		private void personSearchBox_OnSelectionChanged(object sender, ChoiceBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedPerson = (Person)e.ChosenItem;
		}

		// personPnl
		private void LoadPersonPnl()
		{
			personPnlInfoBox.BindPerson(_selectedPerson, _companyManager.GetCompanies());
			projectBox.SetData("Projects", _projectManager.GetProjects(), "Name");
			relationBox.SetData("Närstående", _selectedPerson.Relations, "Person");
		}

		private void personPnlInfoBox_OnSaveChanges(object sender, SaveChangesHandlerEventArgs e)
		{
			_selectedPerson.FirstName = e.FirstName;
			_selectedPerson.LastName = e.LastName;
			_selectedPerson.Birthdate = e.DateOfBirth;
			_selectedPerson.ResidentalAddress.Street = e.Street;
			_selectedPerson.ResidentalAddress.ZipCode = e.PostalCode;
			_selectedPerson.ResidentalAddress.City = e.City;
			_selectedPerson.PhoneNumber = e.PhoneNumber;
			_selectedPerson.CellPhoneNumber = e.CellPhoneNumber;
			_selectedPerson.EmailAddress = e.EmailAddress;
			_selectedPerson.Type = e.Type;
			// Ska läggas in sätt att ändra företag. Måste välja bland befintliga och tas bort från tidigare företag.
			RefreshPersonSearchBox();
			this.Text = _selectedPerson.ToString();
		}

		private void RefreshPersonSearchBox()
		{
			personSearchControl.ResetListBoxData();
			personSearchControl.BindListBoxData(_personManager.GetPersons(), "Person");
		}

		private void personPopUpBtn_Click(object sender, EventArgs e)
		{
			PersonPopUp personPopUp = new PersonPopUp(_selectedPerson, _companyManager, _projectManager);
			personPopUp.ShowDialog();
			LoadPersonPnl();
			this.Text = _selectedPerson.ToString();
		}
		#endregion

		#region "Client"
		private void clientSearchBox_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Company> searchResult = _companyManager.GetCompanies().Where(c => c.Name.ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				companySearchControl.BindListBoxData(searchResult, "Name");
		}

		private void clientSearchBox_OnGoToChoice(object sender, GoToChoiceHandlerEventArgs e)
		{
			this.Text = _selectedCompany.Name;
			HidePanels();
			HideUserControls();
			companyControl.Visible = true;
			companyControl.SetCompanyInfo(_selectedCompany);
			this.companyControl.Location = new System.Drawing.Point(210, 10);
		}
		
		private void companySearchControl_OnCreate()
		{
			CreateCompanyForm createCompanyForm = new CreateCompanyForm(_companyManager);
			createCompanyForm.ShowDialog();
			RefreshCompanySearchBox();
		}

		private void clientSearchBox_OnSelectionChanged(object sender, ChoiceBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedCompany = (Company)e.ChosenItem;
		}

		private void clientSearchBox_OnDoubleClickChoice(object sender, DoubleClickChoiceHandlerEventArgs e)
		{
			CompanyPopUp companyPopUp = new CompanyPopUp(_selectedCompany);
			companyPopUp.ShowDialog();
			RefreshCompanySearchBox();
		}

		private void companyUserForm_OnSaveCompanyChanges(object sender, SaveCompanyChangesHandlerEventArgs e)
		{
			_selectedCompany.Name = e.Name;
			_selectedCompany.Id = e.Id;
			_selectedCompany.Location.Street = e.Street;
			_selectedCompany.Location.ZipCode = e.ZipCode;
			_selectedCompany.Location.City = e.City;
			_selectedCompany.IsActive = e.IsActive;

			RefreshCompanySearchBox();
			this.Text = _selectedCompany.Name;
		}

		private void companyUserForm_OnClosePopUp()
		{
			RefreshCompanySearchBox();
			this.Text = _selectedCompany.Name;
		}

		private void RefreshCompanySearchBox()
		{
			companySearchControl.ResetListBoxData();
			companySearchControl.BindListBoxData(_companyManager.GetCompanies(), "Name");
		}
		#endregion

		#region "Project"
		private void GoToProject(Project currentProject)
		{
			this.Text = currentProject.Name;
			projectPnl.Visible = true;
			this.projectPnl.Location = new System.Drawing.Point(520, 0);
		}

		private void projectSearchBox_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Project> searchResult = _projectManager.GetProjects().Where(p => p.Name.ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				projectSearchControl.BindListBoxData(searchResult, "Name");
		}

		private void projectSearchBox_OnGoToChoice(object sender, GoToChoiceHandlerEventArgs e)
		{
			Project project = (Project)e.ChosenItem;
			GoToProject(project);
		}
		#endregion

        private void projectSearchControl_Load(object sender, EventArgs e)
        {

        }

        private void projectSearchControl_OnCreate()
        {
            CreateProjectForm createProjectForm = new CreateProjectForm(_projectManager, _personManager);
            createProjectForm.Show();
        }
	}
}
