using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase;

namespace TestClasses
{
	public class PersonManager
	{
		private static List<Person> _persons;
		public List<Person> GetPersons()
		{
			return _persons;
		}

		public void CreatePerson()
		{
			Person person = new Person();
			person.Id = _persons.Count + 1;
			person.Relations = new List<Person>();
			person.IsActive = true;

			_persons.Add(person);
		}

		public PersonManager()
		{
			_persons = new List<Person>();
		}
	}
}
