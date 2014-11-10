using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase;

namespace TestClasses
{
	public class CompanyManager
	{
		private static List<Company> _companies;
		public List<Company> GetCompanies()
		{
			return _companies;
		}

		public void CreateCompany(string name)
		{
			Company company = new Company(name);
			company.Employees = new List<Person>();
			company.Projects = new List<Project>();
			company.IsActive = true;
			_companies.Add(company);
		}

		public CompanyManager()
		{
			_companies = new List<Company>();
		}
	}
}
