﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase;

namespace TestClasses
{
	public class ProjectManager
	{
		private static List<Project> _projects;
		public List<Project> GetProjects()
		{
			return _projects;
		}

		public void CreateProject()
		{
			Project project = new Project();
			project.Id = _projects.Count + 1;
			project.Notes = new List<Note>();
			project.Roles = new List<string>();
			project.IsActive = true;

			_projects.Add(project);
		}

		public ProjectManager()
		{
			_projects = new List<Project>();
		}
	}
}