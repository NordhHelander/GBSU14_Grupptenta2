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
	public class CompanyManager
	{
		[XmlArray("CompanyList"), XmlArrayItem(typeof(Company), ElementName = "Company")]

		public BindingList<Company> Companies { get; private set; }

		public void CreateCompany(string name)
		{
			Company company = new Company(name);
			company.Id = Companies.Count + 1;
			company.Employees = new BindingList<Person>();
			company.Projects = new List<Project>();
			company.IsActive = true;
			company.Location = new Address();
			Companies.Add(company);
		}

		public CompanyManager()
		{
			Companies = new BindingList<Company>();
			//Companies = SaveDataXml.LoadCompanies();
		}
	}
}
