using System;
using System.Collections.Generic;
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
        public List<Note> Notes { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }

        public List<Person> Relations { get; set; }

        public string Password { get; set; }

        public Person()
        {

        }

        public Person(string name)
        {
            FirstName = name;
        }

		public override string ToString()
		{
			return FirstName + " " + LastName;
		}
    }
}
