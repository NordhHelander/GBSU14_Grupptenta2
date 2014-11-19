using CodeBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupptenta2
{
	public partial class CreateProjectForm : Form
	{
		private static ProjectManager _projectManager;
		private static PersonManager _personManager;
		private static Person _person;
		private static CompanyManager _companyManager;
		private static Company _company;
		private static Project _newProject;
		private static BindingList<Person> _tempParticipantList;

		public CreateProjectForm(ProjectManager projectManager, PersonManager personManager, CompanyManager companyManager)
		{
			_projectManager = projectManager;
			_personManager = personManager;
			_companyManager = companyManager;

			InitializeComponent();
		}

		public CreateProjectForm(Company company, ProjectManager projectManager, PersonManager personManager, CompanyManager companyManager)
		{
			_company = company;
			_projectManager = projectManager;
			_personManager = personManager;
			_companyManager = companyManager;

			InitializeComponent();
		}

		public CreateProjectForm(Person person, ProjectManager projectManager, PersonManager personManager, CompanyManager companyManager)
		{
			_person = person;
			_projectManager = projectManager;
			_personManager = personManager;
			_companyManager = companyManager;

			InitializeComponent();
		}

		private void CreateProjectForm_Load(object sender, EventArgs e)
		{
			this.Text = "Nytt projekt";
			companyBox.DataSource = _companyManager.Companies;
			companyBox.DisplayMember = "Name";

			_tempParticipantList = new BindingList<Person>();
			participantBox.DataSource = _tempParticipantList;
			participantBox.DisplayMember = "Person";

			if (_company != null)
			{
				companyBox.SelectedItem = _company;
				companyBox.Enabled = false;
			}
			if (_person != null)
			{
				_tempParticipantList.Add(_person);
			}
			createProjectContainer.Panel2.Hide();
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			createProjectContainer.Panel2.Show();
			projectNameBox.ReadOnly = true;
			companyBox.Enabled = false;
			projectDescBox.ReadOnly = true;
			saveBtn.Enabled = false;

			_projectManager.CreateProject(projectNameBox.Text);
			_newProject = _projectManager.Projects[_projectManager.Projects.Count - 1];
			_newProject.Description = projectDescBox.Text;
			// Se till att den inloggade personalen automatiskt läggs till i deltagarlistan.
			Company company = (Company)companyBox.SelectedItem;
			company.Projects.Add(_newProject);

			personBox.DataSource = company.Employees;
			personBox.DisplayMember = "Person";

            SaveDataXml.SaveAll(_companyManager.Companies, _personManager.Persons, _projectManager.Projects);
		}

		private void addPartBtn_Click(object sender, EventArgs e)
		{
			if(!_tempParticipantList.Contains((Person)personBox.SelectedItem))
				_tempParticipantList.Add((Person)personBox.SelectedItem);

			participantBox.DataSource = null;
			participantBox.DataSource = _tempParticipantList;
			participantBox.DisplayMember = "Person";
		}

		private void removePartBtn_Click(object sender, EventArgs e)
		{
			_tempParticipantList.Remove((Person)participantBox.SelectedItem);
			participantBox.DataSource = null;
			participantBox.DataSource = _tempParticipantList;
			participantBox.DisplayMember = "Person";
		}

		private void saveParticipantsBtn_Click(object sender, EventArgs e)
		{
			_newProject.Roles = _tempParticipantList;
            SaveDataXml.SaveAll(_companyManager.Companies, _personManager.Persons, _projectManager.Projects);
            this.Close();
		}
	}
}
