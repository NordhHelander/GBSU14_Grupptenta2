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
		private static PersonManager _personManager = new PersonManager();
		private static CompanyManager _companyManager = new CompanyManager();
		private static ProjectManager _projectManager = new ProjectManager();
		private Person _selectedPerson;
		private Company _selectedCompany;

		public MainForm()
		{
			InitializeComponent();
			CreateMocks();
			this.Width = 1100;
			this.Height = 675;
			LoadPanelsList();
			HidePanels();
			HideUserControls();
			SetEventMethods();
		}

		private void SetEventMethods()
		{
			personSearchBox.OnGoToChoice += personSearchBox_OnGoToChoice;
			personSearchBox.OnSearch += personSearchBox_OnSearch;
			personSearchBox.OnCreate += personSearchBox_OnCreate;
			personSearchBox.OnDoubleClickChoice += personSearchBox_OnDoubleClickChoice;
			personSearchBox.OnSelectionChanged += personSearchBox_OnSelectionChanged;
			clientSearchBox.OnGoToChoice += clientSearchBox_OnGoToChoice;
			clientSearchBox.OnSearch += clientSearchBox_OnSearch;
			projectSearchBox.OnGoToChoice += projectSearchBox_OnGoToChoice;
			projectSearchBox.OnSearch += projectSearchBox_OnSearch;
			personPnlInfoBox.OnSaveChanges += personPnlInfoBox_OnSaveChanges;

			companyUserForm.OnSaveCompanyChanges += companyUserForm_OnSaveCompanyChanges;
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
				_projectManager.CreateProject();
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
			_panels.Add(choosePersonPnl);
			_panels.Add(chooseClientPnl);
			_panels.Add(chooseProjectPnl);
			_panels.Add(profilePnl);
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
			companyUserForm.Visible = false;
		}

		#endregion

		#region "Main Menu Items"
		private void logOutBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void quitBtn_Click(object sender, EventArgs e)
		{
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
			SwitchPanel(chooseProjectPnl);
			this.chooseProjectPnl.Location = new System.Drawing.Point(200, 0);

			projectSearchBox.BindListBoxData(_projectManager.GetProjects(), "Name");
		}
		private void clientBtn_Click(object sender, EventArgs e)
		{
			this.Text = "Dina företagskunder";
			SwitchPanel(chooseClientPnl);
			this.chooseClientPnl.Location = new System.Drawing.Point(200, 0);

			clientSearchBox.BindListBoxData(_companyManager.GetCompanies(), "Name");
		}
		private void contactsBtn_Click(object sender, EventArgs e)
		{
			this.Text = "Dina kontakter";
			SwitchPanel(choosePersonPnl);
			this.choosePersonPnl.Location = new System.Drawing.Point(200, 0);

			personSearchBox.BindListBoxData(_personManager.GetPersons(), "Person");
		}
		#endregion

		#region "Person"
		// choosePersonPnl
		private void personSearchBox_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Person> searchResult = _personManager.GetPersons().Where(p => p.ToString().ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				personSearchBox.BindListBoxData(searchResult, "Person");
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
			personSearchBox.ResetListBoxData();
			personSearchBox.BindListBoxData(_personManager.GetPersons(), "Person");
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
		private void GoToClient(Company company)
		{
			this.Text = company.Name;
			HidePanels();
			companyUserForm.Visible = true;
			companyUserForm.SetCompanyInfo(company);

			this.companyUserForm.Location = new System.Drawing.Point(210, 10);
		}

		private void clientSearchBox_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Company> searchResult = _companyManager.GetCompanies().Where(c => c.Name.ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				clientSearchBox.BindListBoxData(searchResult, "Name");
		}

		private void clientSearchBox_OnGoToChoice(object sender, GoToChoiceHandlerEventArgs e)
		{
			_selectedCompany = (Company)e.ChosenItem;
			GoToClient(_selectedCompany);
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

		private void RefreshCompanySearchBox()
		{
			clientSearchBox.ResetListBoxData();
			clientSearchBox.BindListBoxData(_companyManager.GetCompanies(), "Name");
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
				projectSearchBox.BindListBoxData(searchResult, "Name");
		}

		private void projectSearchBox_OnGoToChoice(object sender, GoToChoiceHandlerEventArgs e)
		{
			Project project = (Project)e.ChosenItem;
			GoToProject(project);
		}
		#endregion
	}
}
