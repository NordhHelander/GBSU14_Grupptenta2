using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeBase;
using TestClasses;

namespace Grupptenta2
{
	public partial class EditParticipantListForm : Form
	{
		private static Project _project;
		private static Company _company;
		private static BindingList<Person> _tempParticipantList;

		public EditParticipantListForm(Project project, Company company)
		{
			_project = project;
			_company = company;
			_tempParticipantList = _project.Roles;

			InitializeComponent();
			this.Text = "Ändra deltagarlistan";
			personBox.DataSource = company.Employees;
			personBox.DisplayMember = "Person";
			participantBox.DataSource = _tempParticipantList;
			participantBox.DisplayMember = "Person";
		}

		private void addPartBtn_Click(object sender, EventArgs e)
		{
			_tempParticipantList.Add((Person)personBox.SelectedItem);
			participantBox.DataSource = null;
			participantBox.DataSource = _tempParticipantList;
			participantBox.DisplayMember = "Person";
		}

		private void removePartBtn_Click(object sender, EventArgs e)
		{
			_tempParticipantList.Remove((Person)personBox.SelectedItem);
			participantBox.DataSource = null;
			participantBox.DataSource = _tempParticipantList;
			participantBox.DisplayMember = "Person";
		}

		private void saveParticipantsBtn_Click(object sender, EventArgs e)
		{
			_project.Roles = _tempParticipantList;
			this.Close();
		}
	}
}
