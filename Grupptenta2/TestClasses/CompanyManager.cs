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
    [XmlRoot("Foo")]
    public class CompanyManager
	{
        [XmlArray("CompanyList"), XmlArrayItem(typeof(Company), ElementName = "Company")]
        public BindingList<Company> _companies;
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
			_companies.Add(company);
		}

		public CompanyManager()
		{
            _companies = new BindingList<Company>();
            _companies = SaveDataXml.LoadCompanies();
		}
	}
}
