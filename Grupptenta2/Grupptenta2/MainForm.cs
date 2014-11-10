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

		public MainForm()
		{
			InitializeComponent();
			MockPersons.CreatePersons(5, _personManager);
			this.Width = 800;
			this.Height = 415;
			LoadPanelsList();
			HidePanels();

			searchBox1.SearchText = "Nisse";
			searchBox1.OnSearch += searchBox1_OnSearch;
			
			searchBox1.OrderBy_Datasource = new List<string> { "Test1", "Test2" };
			searchBox1.OnOrderByChanged += searchBox1_OnFilterChanged;
		}

		public void searchBox1_OnSearch(object sender, SearchHandlerEventArgs e)
		{
			var searchText = e.SearchText;
		}

		public void searchBox1_OnFilterChanged(object sender, OrderByHandlerEventArgs e)
		{
			var i = 1;
		}


		// PANEL CONTROL
		private void LoadPanelsList()
		{
			_panels.Add(choicePnl);
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

		private void projectBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(choicePnl);
			this.choicePnl.Location = new System.Drawing.Point(200, 0);
		}

		private void calendarBtn_Click(object sender, EventArgs e)
		{
			//SwitchPanel(calendarPnl);
			//this.calendarPnl.Location = new System.Drawing.Point(200, 0);
		}

		private void contactsBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(choicePnl);
			this.choicePnl.Location = new System.Drawing.Point(200, 0);
		}

		private void clientBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(choicePnl);
			this.choicePnl.Location = new System.Drawing.Point(200, 0);
		}

		private void logOutBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void quitBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
