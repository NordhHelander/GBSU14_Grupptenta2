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
            project.Notes = new List<Note>();
			project.Roles = new List<Person>();
			project.IsActive = true;

			Projects.Add(project);
		}

		public void CreateProject(string name, List<Person> participants)
		{
			Project project = new Project();
			project.Id = Projects.Count + 1;
			project.Name = name;
			project.Notes = new List<Note>();
			project.Roles = participants;
			project.IsActive = true;

			Projects.Add(project);
		}

		public ProjectManager()
		{
			Projects = new BindingList<Project>();
			Projects = SaveDataXml.LoadProjects();
		}
	}
}
