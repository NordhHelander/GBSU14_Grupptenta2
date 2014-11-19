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

namespace Grupptenta2
{
	public partial class EditProjectParticipantListForm : Form
	{
		private static Project _project;
		private static CompanyManager _companyManager;
		private static BindingList<Person> _tempParticipantList;

		public EditProjectParticipantListForm(Project project, CompanyManager companyManager)
		{
			_project = project;
			_companyManager = companyManager;
			_tempParticipantList = _project.Roles;

			InitializeComponent();

			Company company = _companyManager.Companies.SingleOrDefault(c => c.Projects.Any(p => p.Id == _project.Id));
			personBox.DataSource = company.Employees;
			personBox.DisplayMember = "Person";
			participantBox.DataSource = _tempParticipantList;
			participantBox.DisplayMember = "Person";
		}

		private void addPartBtn_Click(object sender, EventArgs e)
		{
			_tempParticipantList.Add((Person)personBox.SelectedItem);
		}

		private void removePartBtn_Click(object sender, EventArgs e)
		{
			_tempParticipantList.Remove((Person)personBox.SelectedItem);
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			_project.Roles = _tempParticipantList;
			this.Close();
		}
	}
}
