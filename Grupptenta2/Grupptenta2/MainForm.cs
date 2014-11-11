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

		public MainForm()
		{
			InitializeComponent();
			CreateMocks();
			this.Width = 900;
			this.Height = 415;
			LoadPanelsList();
			HidePanels();

			personSearchBox.OnGoToChoice += personSearchBox_OnGoToChoice;
			personSearchBox.OnSearch += personSearchBox_OnSearch;
			clientSearchBox.OnGoToChoice += clientSearchBox_OnGoToChoice;
			clientSearchBox.OnSearch += clientSearchBox_OnSearch;
			projectSearchBox.OnGoToChoice += projectSearchBox_OnGoToChoice;
			projectSearchBox.OnSearch += projectSearchBox_OnSearch;
		}

		// PANEL CONTROL
		private void LoadPanelsList()
		{
			_panels.Add(personPnl);
			_panels.Add(projectPnl);
			_panels.Add(clientPnl);
			_panels.Add(choosePersonPnl);
			_panels.Add(chooseClientPnl);
			_panels.Add(chooseProjectPnl);
		}
		private void SwitchPanel(Panel panel)
		{
			panel.Visible = true;
			HideAllPanelsExceptThis(panel);
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

		// MENU ITEMS
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
		}
		private void calendarBtn_Click(object sender, EventArgs e)
		{
			//SwitchPanel(calendarPnl);
			//this.calendarPnl.Location = new System.Drawing.Point(200, 0);
		}
		private void projectBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(chooseProjectPnl);
			this.chooseProjectPnl.Location = new System.Drawing.Point(200, 0);

			projectSearchBox.BindListBoxData(_projectManager.GetProjects(), "Name");
		}
		private void clientBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(chooseClientPnl);
			this.chooseClientPnl.Location = new System.Drawing.Point(200, 0);

			clientSearchBox.BindListBoxData(_companyManager.GetCompanies(), "Name");
		}
		private void contactsBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(choosePersonPnl);
			this.choosePersonPnl.Location = new System.Drawing.Point(200, 0);

			personSearchBox.BindListBoxData(_personManager.GetPersons(), "Person");
		}

		private void GoToPerson(Person currentPerson)
		{
			SwitchPanel(personPnl);
			this.personPnl.Location = new System.Drawing.Point(200, 0);

			personInfoBox1.BindPerson(currentPerson, _companyManager.GetCompanies());
			projectBox.SetData("Projects", _projectManager.GetProjects(), "Name");
			relationBox.SetData("Närstående", currentPerson.Relations, "Person");
		}
		private void GoToClient(Company currentCompany)
		{
			clientPnl.Visible = true;
			this.clientPnl.Location = new System.Drawing.Point(520, 0);
		}
		private void GoToProject(Project currentProject)
		{
			projectPnl.Visible = true;
			this.projectPnl.Location = new System.Drawing.Point(520, 0);
		}

		// ChoosePerson-events
		private void personSearchBox_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Person> searchResult = _personManager.GetPersons().Where(p => p.ToString().ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				personSearchBox.BindListBoxData(searchResult, "Person");
		}
		private void personSearchBox_OnGoToChoice(object sender, GoToChoiceHandlerEventArgs e)
		{
			Person person = (Person)e.ChosenItem;
			GoToPerson(person);
		}

		// ChooseClient-events
		private void clientSearchBox_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			string searchText = e.SearchText;
			List<Company> searchResult = _companyManager.GetCompanies().Where(c => c.Name.ToLower().Contains(searchText.ToLower())).ToList();
			if (searchResult.Count > 0)
				clientSearchBox.BindListBoxData(searchResult, "Name");
		}
		private void clientSearchBox_OnGoToChoice(object sender, GoToChoiceHandlerEventArgs e)
		{
			Company company = (Company)e.ChosenItem;
			GoToClient(company);
		}

		// ChooseProject-events
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

		// MOCK SETUP
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
				_personManager.CreatePerson();
				_personManager.GetPersons()[i].FirstName = "Per" + (i + 1);
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
	}
}
