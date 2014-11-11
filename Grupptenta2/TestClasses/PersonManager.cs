using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase;
using System.ComponentModel;

namespace TestClasses
{
	public class PersonManager
	{
		private static BindingList<Person> _persons;
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
