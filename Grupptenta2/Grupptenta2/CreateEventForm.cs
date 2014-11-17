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
	public partial class CreateEventForm : Form
	{
		private static Project _project;
		//private static BindingList<Note> _tempNotes;
		//private static BindingList<Person> _tempParticipants;

		public CreateEventForm(Project project)
		{
			_project = project;

			InitializeComponent();
			this.Text = "Skapa händelse";
			eventCreationContainer.Panel2.Hide();
			personList.DataSource = _project.Roles;
			personList.DisplayMember = "Person";
		}

		private void isMeetingCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (isMeetingCheckBox.Checked == true)
			{
				eventCreationContainer.Panel2.Show();
			}
			else
			{
				eventCreationContainer.Panel2.Hide();
			}
		}
	}
}

