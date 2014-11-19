using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
	[Serializable]
	public class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime Birthdate { get; set; }
		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }
		public string CellPhoneNumber { get; set; }
		public Address ResidentialAddress { get; set; }
		public BindingList<Note> Notes { get; set; }
		public string Type { get; set; }
		public bool IsActive { get; set; }

		public BindingList<Person> Relations { get; set; }

		public string Password { get; set; }

		public Person()
		{

		}

		public Person(string name)
		{
			FirstName = name;
			Notes = new BindingList<Note>();
		}

		public override string ToString()
		{
			return FirstName + " " + LastName;
		}
	}
}
