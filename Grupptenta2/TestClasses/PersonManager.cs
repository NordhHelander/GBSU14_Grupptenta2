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
    //[XmlRoot("Foo")]
    public class PersonManager
	{
		[XmlArray("PersonList"), XmlArrayItem(typeof(Person), ElementName = "Person")]

		public BindingList<Person> Persons { get; private set; }

		public void CreatePerson(string name)
		{
			Person person = new Person(name);
			person.Id = Persons.Count + 1;
			person.ResidentalAddress = new Address();
			person.Relations = new List<Person>();
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
