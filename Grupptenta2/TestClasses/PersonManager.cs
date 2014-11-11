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
		public List<Person> Persons { get; private set; }

		public void CreatePerson()
		{
			Person person = new Person("Adam");
			person.Id = Persons.Count + 1;
		}

		public void CreatePerson(string firstName, string lastName, string cellPhone, string phone, string password) 
		{
			Person person = new Person("Bertil");
			person.FirstName = firstName;
			person.LastName = lastName;
			person.CellPhoneNumber = cellPhone;
			person.PhoneNumber = phone;
			person.Password = password;

			Persons.Add(person);
		}

		public PersonManager()
		{
			Persons = new List<Person>();
		}
	}
}
