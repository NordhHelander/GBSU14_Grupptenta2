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
		private static List<Panel> _panels;
		private static List<UserControl> _userControls;
		private static PersonManager _personManager;
		private static CompanyManager _companyManager;
		private static ProjectManager _projectManager;
		private Person _selectedPerson;
		private Company _selectedCompany;
		private Project _selectedProject;

		public MainForm()
		{
			_panels = new List<Panel>();
			_userControls = new List<UserControl>();
			_personManager = new PersonManager();
			_companyManager = new CompanyManager();
			_projectManager = new ProjectManager();

			InitializeComponent();
			this.ClientSize = new Size(1100, 675);

			//CreateMocks();
			//SaveDataXml.SaveCompanies(_companyManager.Companies);
			//SaveDataXml.SavePersons(_personManager.Persons);
			//SaveDataXml.SaveProjects(_projectManager.Projects);

			LoadPanelsList();
			HidePanels();
			LoadUserControlList();
			HideUserControls();
			SetEventMethods();
		}

		//private static void CreateMocks()
		//{
		//	int numberOfCompanies = 3;
		//	int numberOfPersons = 12;
		//	int numberOfProjects = 6;

		//	for (int i = 0; i < numberOfCompanies; i++)
		//	{
		//		_companyManager.CreateCompany("Company no." + (i + 1));
		//	}

		//	for (int i = 0; i < numberOfPersons; i++)
		//	{
		//		_personManager.CreatePerson("Per" + (i + 1));
		//		_personManager.Persons[i].LastName = "Persson" + (i + 1);
		//		_personManager.Persons[i].Birthdate = DateTime.Today.AddYears(-(i + 1));
		//		_personManager.Persons[i].EmailAddress = "Per" + (i + 1) + "@" + "Persson" + (i + 1) + ".com";
		//	}

		//	for (int i = 0; i < numberOfProjects; i++)
		//	{
		//		_projectManager.CreateProject("Project no." + (i + 1), _personManager.Persons[i]);
		//		_projectManager.Projects[i].Name = "Project no." + (i + 1);
		//		_projectManager.Projects[i].ProjectJournal = new Journal();
		//	}

		//	_companyManager.Companies[0].Employees.Add(_personManager.Persons[0]);
		//	_companyManager.Companies[0].Employees.Add(_personManager.Persons[1]);
		//	_companyManager.Companies[0].Employees.Add(_personManager.Persons[2]);
		//	_companyManager.Companies[0].Employees.Add(_personManager.Persons[3]);
		//	_companyManager.Companies[1].Employees.Add(_personManager.Persons[4]);
		//	_companyManager.Companies[1].Employees.Add(_personManager.Persons[5]);
		//	_companyManager.Companies[1].Employees.Add(_personManager.Persons[6]);
		//	_companyManager.Companies[1].Employees.Add(_personManager.Persons[7]);
		//	_companyManager.Companies[2].Employees.Add(_personManager.Persons[8]);
		//	_companyManager.Companies[2].Employees.Add(_personManager.Persons[9]);
		//	_companyManager.Companies[2].Employees.Add(_personManager.Persons[10]);
		//	_companyManager.Companies[2].Employees.Add(_personManager.Persons[11]);

		//	_companyManager.Companies[0].Projects.Add(_projectManager.Projects[0]);
		//	_companyManager.Companies[0].Projects.Add(_projectManager.Projects[1]);
		//	_companyManager.Companies[1].Projects.Add(_projectManager.Projects[2]);
		//	_companyManager.Companies[1].Projects.Add(_projectManager.Projects[3]);
		//	_companyManager.Companies[2].Projects.Add(_projectManager.Projects[4]);
		//	_companyManager.Companies[2].Projects.Add(_projectManager.Projects[5]);
		//}

		private void SetEventMethods()
		{
			personSearchControl.OnSearch += personSearchBox_OnSearch;
			personSearchControl.OnGoToChoice += personSearchBox_OnGoToChoice;
			personSearchControl.OnCreate += personSearchBox_OnCreate;
			personSearchControl.OnSelectionChanged += personSearchBox_OnSelectionChanged;
			personSearchControl.OnDoubleClickChoice += personSearchBox_OnDoubleClickChoice;

			personControl.OnSavePersonChanges += personControl_OnSavePersonChanges;
			personControl.OnClosePopUp += personControl_OnClosePopUp;

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
		}

		#region "Panel Control"
		private void LoadPanelsList()
		{
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
			_userControls.Add(personControl);
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

		private void projectBtn_Click(object sender, EventArgs e)
		{
			this.Text = "Dina projekt";
			HidePanels();
			HideUserControls();
			projectSearchControl.Visible = true;
			this.projectSearchControl.Location = new System.Drawing.Point(210, 10);
			projectSearchControl.BindListBoxData(_projectManager.Projects, "Name");
		}

		private void clientBtn_Click(object sender, EventArgs e)
		{
			this.Text = "Dina företagskunder";
			HidePanels();
			HideUserControls();
			companySearchControl.Visible = true;
			this.companySearchControl.Location = new System.Drawing.Point(210, 10);
			companySearchControl.BindListBoxData(_companyManager.Companies, "Name");
		}

		private void contactsBtn_Click(object sender, EventArgs e)
		{
			this.Text = "Dina kontakter";
			HidePanels();
			HideUserControls();
			personSearchControl.Visible = true;
			this.personSearchControl.Location = new System.Drawing.Point(210, 10);
			personSearchControl.BindListBoxData(_personManager.Persons, "Person");
		}

		private void profileBtn_Click(object sender, EventArgs e)
		{
			this.Text = "Din profil";
		}
		private void calendarBtn_Click(object sender, EventArgs e)
		{
			this.Text = "Kalender";
		}
		#endregion

		#region "Person"
		private void personSearchBox_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Person> searchResult = _personManager.Persons.Where(p => p.ToString().ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				personSearchControl.BindListBoxData(searchResult, "Person");
		}
		private void personSearchBox_OnGoToChoice(object sender, GoToChoiceHandlerEventArgs e)
		{
			this.Text = _selectedPerson.ToString();
			HidePanels();
			HideUserControls();
			personControl.Visible = true;
			personControl.SetPersonInfo(_selectedPerson, _companyManager);
			this.personControl.Location = new System.Drawing.Point(210, 10);
		}
		private void personSearchBox_OnCreate()
		{
			CreatePersonForm createPersonForm = new CreatePersonForm(_personManager, _companyManager);
			createPersonForm.ShowDialog();
			RefreshPersonSearchBox();
		}
		private void personSearchBox_OnDoubleClickChoice(object sender, DoubleClickChoiceHandlerEventArgs e)
		{
			PersonPopUp personPopUp = new PersonPopUp(_selectedPerson, _companyManager);
			personPopUp.ShowDialog();
			RefreshPersonSearchBox();
		}
		private void personSearchBox_OnSelectionChanged(object sender, ChoiceBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedPerson = (Person)e.ChosenItem;
		}
		private void personControl_OnSavePersonChanges(object sender, SavePersonChangesHandlerEventArgs e)
		{
			_selectedPerson.FirstName = e.FirstName;
			_selectedPerson.LastName = e.LastName;
			_selectedPerson.Birthdate = e.DateOfBirth;
			_selectedPerson.ResidentialAddress.Street = e.Street;
			_selectedPerson.ResidentialAddress.ZipCode = e.ZipCode;
			_selectedPerson.ResidentialAddress.City = e.City;
			_selectedPerson.PhoneNumber = e.PhoneNumber;
			_selectedPerson.CellPhoneNumber = e.CellPhoneNumber;
			_selectedPerson.EmailAddress = e.EmailAddress;
			_selectedPerson.Type = e.Type;
			// Ska läggas in sätt att ändra företag. Måste välja bland befintliga och tas bort från tidigare företag.
			RefreshPersonSearchBox();
			this.Text = _selectedPerson.ToString();
		}
		private void personControl_OnClosePopUp()
		{
			RefreshPersonSearchBox();
			this.Text = _selectedPerson.ToString();
		}
		private void RefreshPersonSearchBox()
		{
			personSearchControl.ResetListBoxData();
			personSearchControl.BindListBoxData(_personManager.Persons, "Person");
		}
		#endregion

		#region "Company"
		private void companySearchBox_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Company> searchResult = _companyManager.Companies.Where(c => c.Name.ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				companySearchControl.BindListBoxData(searchResult, "Name");
		}
		private void companySearchBox_OnGoToChoice(object sender, GoToChoiceHandlerEventArgs e)
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
		private void companySearchBox_OnSelectionChanged(object sender, ChoiceBoxSelectionChangedHandlerEventArgs e)
		{
			_selectedCompany = (Company)e.ChosenItem;
		}
		private void companySearchBox_OnDoubleClickChoice(object sender, DoubleClickChoiceHandlerEventArgs e)
		{
			CompanyPopUp companyPopUp = new CompanyPopUp(_selectedCompany);
			companyPopUp.ShowDialog();
			RefreshCompanySearchBox();
		}
		private void companyControl_OnSaveCompanyChanges(object sender, SaveCompanyChangesHandlerEventArgs e)
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
		private void companyControl_OnClosePopUp()
		{
			RefreshCompanySearchBox();
			this.Text = _selectedCompany.Name;
		}
		private void RefreshCompanySearchBox()
		{
			companySearchControl.ResetListBoxData();
			companySearchControl.BindListBoxData(_companyManager.Companies, "Name");
		}
		#endregion

		#region "Project"
		private void projectSearchBox_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Project> searchResult = _projectManager.Projects.Where(p => p.Name.ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				projectSearchControl.BindListBoxData(searchResult, "Name");
		}
		private void projectSearchBox_OnGoToChoice(object sender, GoToChoiceHandlerEventArgs e)
		{
			_selectedProject = (Project)e.ChosenItem;

			this.Text = _selectedProject.Name;
			projectPnl.Visible = true;
			this.projectPnl.Location = new System.Drawing.Point(520, 0);
		}
		private void projectSearchControl_OnCreate()
		{
			CreateProjectForm createProjectForm = new CreateProjectForm(_projectManager, _personManager);
			createProjectForm.Show();
			RefreshProjectSearchBox();
		}
		private void projectSearchControl_OnSelectionChanged(object sender, ChoiceBoxSelectionChangedHandlerEventArgs e)
		{
			throw new NotImplementedException();
		}
		private void projectSearchControl_OnDoubleClickChoice(object sender, DoubleClickChoiceHandlerEventArgs e)
		{
			throw new NotImplementedException();
		}
		private void RefreshProjectSearchBox()
		{
			projectSearchControl.ResetListBoxData();
			projectSearchControl.BindListBoxData(_projectManager.Projects, "Name");
		}
		#endregion
	}
}
