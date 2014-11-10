using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public Address ResidentalAddress { get; set; }
        public string Notes { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }

        public List<Person> Relations { get; set; }

        public string Password { get; set; }

		// Lagt till en ToString-metod för att få snyggare person-presentationer i personlistor. /Tanya
		public override string ToString()
		{
			return string.Format("{0} {1}", FirstName, LastName);
		}
    }
}
