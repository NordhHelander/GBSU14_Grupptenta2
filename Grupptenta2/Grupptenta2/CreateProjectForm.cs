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
using TestClasses;

namespace Grupptenta2
{
    public partial class CreateProjectForm : Form
    {
        private static ProjectManager _projectManager;
        private static PersonManager _personManager;

        public CreateProjectForm(ProjectManager projectManager, PersonManager personManager)
        {
            _projectManager = projectManager;
            _personManager = personManager;

            InitializeComponent();
        }

        private void CreateProjectForm_Load(object sender, EventArgs e)
        {
            lstBx_Participants.DataSource = _personManager.Persons;
            lstBx_Participants.DisplayMember = _personManager.Persons.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            _projectManager.CreateProject(nameBox.Text, (Person)lstBx_Participants.SelectedItem);
            int indexOfNewProject = _projectManager.Projects.Count - 1;
            Project project = _projectManager.Projects[indexOfNewProject];
            this.Close();
        }
    }
}
