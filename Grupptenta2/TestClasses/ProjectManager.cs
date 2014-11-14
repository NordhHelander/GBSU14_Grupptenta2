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
        public BindingList<Project> _projects;
		public BindingList<Project> GetProjects()
		{
			return _projects;
		}

		public void CreateProject(string name, Person participant)
		{
			Project project = new Project();
            project.Id = _projects.Count + 1;
            project.Name = name;
            project.Notes = new List<Note>();
			project.Roles = new List<Person>();
            project.Roles.Add(participant);
			project.IsActive = true;

			_projects.Add(project);
		}

		public ProjectManager()
		{
			_projects = new BindingList<Project>();
            _projects = SaveDataXml.LoadProjects();
		}
	}
}
