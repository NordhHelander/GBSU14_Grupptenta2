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
        public BindingList<Person> _persons;
		
        public BindingList<Person> GetPersons()
		{
			return _persons;
		}

		public void CreatePerson(string name)
		{
			Person person = new Person(name);
			person.Id = _persons.Count + 1;
			person.Relations = new List<Person>();
			person.IsActive = true;

			_persons.Add(person);
		}

		public PersonManager()
		{
			_persons = new BindingList<Person>();
		}
	}
}
