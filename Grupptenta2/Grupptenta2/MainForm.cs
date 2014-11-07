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
	public partial class MainForm : Form
	{
		private static List<Panel> _panels = new List<Panel>();

		public MainForm()
		{
			InitializeComponent();
			this.Width = 800;
			this.Height = 415;
			LoadPanelsList();
			HidePanels();
		}

		#region "Panel Control"
		private void LoadPanelsList()
		{
			_panels.Add(profilePnl);
			_panels.Add(listProjectsPnl);
			_panels.Add(projectPnl);
			_panels.Add(calendarPnl);
			_panels.Add(listContactsPnl);
			_panels.Add(contactPnl);
			_panels.Add(listClientsPnl);
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
		#endregion

		#region "Menu"
		private void profileBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(profilePnl);
			this.profilePnl.Location = new System.Drawing.Point(200, 0);
		}

		private void projectBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(listProjectsPnl);
			this.listProjectsPnl.Location = new System.Drawing.Point(200, 0);
		}

		private void calendarBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(calendarPnl);
			this.calendarPnl.Location = new System.Drawing.Point(200, 0);
		}

		private void contactsBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(listContactsPnl);
			this.listContactsPnl.Location = new System.Drawing.Point(200, 0);
		}

		private void clientBtn_Click(object sender, EventArgs e)
		{
			SwitchPanel(listClientsPnl);
			this.listClientsPnl.Location = new System.Drawing.Point(200, 0);
		}

		private void logOutBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void quitBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		#endregion

		#region "Project"
		private void goToProjectBtn_Click(object sender, EventArgs e)
		{
			projectPnl.Visible = true;
			this.projectPnl.Location = new System.Drawing.Point(450, 0);
		}

		private void closeProjectPnlBtn_Click(object sender, EventArgs e)
		{
			projectPnl.Visible = false;
		}
		#endregion
		#region "Contact"
		private void goToContactBtn_Click(object sender, EventArgs e)
		{
			contactPnl.Visible = true;
			this.contactPnl.Location = new System.Drawing.Point(450, 0);
		}

		private void closeContactBtn_Click(object sender, EventArgs e)
		{
			contactPnl.Visible = false;
		}
		#endregion
		#region "Client"
		private void goToClientBtn_Click(object sender, EventArgs e)
		{
			clientPnl.Visible = true;
			this.clientPnl.Location = new System.Drawing.Point(450, 0);
		}

		private void closeClientBtn_Click(object sender, EventArgs e)
		{
			clientPnl.Visible = false;
		}
		#endregion
	}
}
