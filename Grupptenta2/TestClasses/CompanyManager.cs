using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase;
using System.ComponentModel;

namespace TestClasses
{
	public class CompanyManager
	{
		private static BindingList<Company> _companies;
		public BindingList<Company> GetCompanies()
		{
			return _companies;
		}

		public void CreateCompany(string name)
		{
			Company company = new Company(name);
			company.Employees = new BindingList<Person>();
			company.Projects = new List<Project>();
			company.IsActive = true;
			company.Location = new Address();
			_companies.Add(company);
		}

		public CompanyManager()
		{
			_companies = new BindingList<Company>();
		}
	}
}
