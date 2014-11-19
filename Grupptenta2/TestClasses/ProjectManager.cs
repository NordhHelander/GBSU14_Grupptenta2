using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TestClasses
{
    [Serializable]
    public class ProjectManager
	{
		[XmlArray("ProjectList"), XmlArrayItem(typeof(Project), ElementName = "Project")]

		public BindingList<Project> Projects { get; private set; }

		public void CreateProject(string name)
		{
			Project project = new Project();
            project.Id = Projects.Count + 1;
            project.Name = name;
			project.ProjectJournal = new Journal();
			project.ProjectJournal.Notes = new BindingList<Note>();
			project.ProjectJournal.Events = new BindingList<ProjectEvent>();
            project.Notes = new BindingList<Note>();
			project.Roles = new BindingList<Person>();
			project.IsActive = true;

			Projects.Add(project);
		}

		public ProjectManager()
		{
			Projects = new BindingList<Project>();
			//Projects = SaveDataXml.LoadProjects();
		}
	}
}
