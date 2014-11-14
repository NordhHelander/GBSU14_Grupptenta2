using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeBase
{
    public static class SaveDataXml
    {
        public static void SaveCompanies(BindingList<Company> companies)
        {
            XmlSerializer ser = new XmlSerializer(typeof(BindingList<Company>));

            using (FileStream fs = new FileStream(@"Companies.xml", FileMode.Create))
            {
                ser.Serialize(fs, companies);
            }
        }

        public static void SavePersons(BindingList<Person> persons)
        {
            XmlSerializer ser = new XmlSerializer(typeof(BindingList<Person>));

            using (FileStream fs = new FileStream(@"Persons.xml", FileMode.Create))
            {
                ser.Serialize(fs, persons);
            }
        }

        public static void SaveProjects(BindingList<Project> projects)
        {
            XmlSerializer ser = new XmlSerializer(typeof(BindingList<Project>));

            using (FileStream fs = new FileStream(@"Projects.xml", FileMode.Create))
            {
                ser.Serialize(fs, projects);
            }
        }

        public static BindingList<Company> LoadCompanies()
        {
            XmlSerializer ser = new XmlSerializer(typeof(BindingList<Company>));

            using (FileStream fs = new FileStream(@"Companies.xml", FileMode.Open))
            {
                return (BindingList<Company>)ser.Deserialize(fs);
            }
        }

        public static BindingList<Person> LoadPersons()
        {
            XmlSerializer ser = new XmlSerializer(typeof(BindingList<Person>));

            using (FileStream fs = new FileStream(@"Persons.xml", FileMode.Open))
            {
                return (BindingList<Person>)ser.Deserialize(fs);
            }
        }

        public static BindingList<Project> LoadProjects()
        {
            XmlSerializer ser = new XmlSerializer(typeof(BindingList<Project>));

            using (FileStream fs = new FileStream(@"Projects.xml", FileMode.Open))
            {
                return (BindingList<Project>)ser.Deserialize(fs);
            }
        }
    }
}
