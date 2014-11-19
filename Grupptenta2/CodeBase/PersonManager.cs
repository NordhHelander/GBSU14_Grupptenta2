using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CodeBase
{
    [Serializable]
    public class PersonManager
	{
		[XmlArray("PersonList"), XmlArrayItem(typeof(Person), ElementName = "Person")]

		public BindingList<Person> Persons { get; private set; }

		public void CreatePerson(string firstName)
		{
			Person person = new Person(firstName);
			person.Id = Persons.Count + 1;
			person.ResidentialAddress = new Address();
			person.Relations = new BindingList<Person>();
			person.IsActive = true;

			Persons.Add(person);
		}

		public PersonManager()
		{
			Persons = new BindingList<Person>();
			Persons = SaveDataXml.LoadPersons();
		}
	}
}
