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

		public delegate void GoToListChoiceEventHandler();
		public event GoToListChoiceEventHandler OnGoToListChoice;


		public MainForm()
		{
			InitializeComponent();
			MockPersons.CreatePersons(5, _personManager);
			this.Width = 800;
			this.Height = 415;
			LoadPanelsList();
			HidePanels();
		}

		// PANEL CONTROL
		private void LoadPanelsList()
		{
			_panels.Add(choicePnl);
			_panels.Add(personPnl);
			_panels.Add(projectPnl);
			_panels.Add(clientPnl);
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
		private void profileBtn_Click(object sender, EventArgs e)
		{
			//SwitchPanel(profilePnl);
			//this.profilePnl.Location = new System.Drawing.Point(200, 0);
		}
		private void calendarBtn_Click(object sender, EventArgs e)
		{
			//SwitchPanel(calendarPnl);
			//this.calendarPnl.Location = new System.Drawing.Point(200, 0);
		}

		private void projectBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(choicePnl);
			this.choicePnl.Location = new System.Drawing.Point(200, 0);

			OnGoToListChoice = GoToProject;
		}

		private void contactsBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(choicePnl);
			this.choicePnl.Location = new System.Drawing.Point(200, 0);

			choiceGrid.DataSource = _personManager.GetPersons();
			CreateCompanyColumnForPerson();
			OnGoToListChoice = GoToPerson;
		}

		private void clientBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(choicePnl);
			this.choicePnl.Location = new System.Drawing.Point(200, 0);

			OnGoToListChoice = GoToClient;
		}

		private void logOutBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void quitBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void goToChoiceBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(choicePnl);
			OnGoToListChoice();
		}
		private void GoToPerson()
		{
			personPnl.Visible = true;
			this.personPnl.Location = new System.Drawing.Point(520, 0);
		}
		private void GoToProject()
		{
			projectPnl.Visible = true;
			this.projectPnl.Location = new System.Drawing.Point(520, 0);
		}
		private void GoToClient()
		{
			clientPnl.Visible = true;
			this.clientPnl.Location = new System.Drawing.Point(520, 0);
		}

		private void CreateCompanyColumnForPerson()
		{
			DataGridViewTextBoxColumn companyColumn = new DataGridViewTextBoxColumn();
			companyColumn.Name = "Company";
			companyColumn.HeaderText = "Företag";
			choiceGrid.Columns.Insert(0, companyColumn);
		}
	}
}
