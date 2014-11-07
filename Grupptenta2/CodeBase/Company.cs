using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Location { get; set; }
        public List<Person> Employees { get; set; }
        public List<Project> Projects { get; set; }    
        public bool IsActive { get; set; }

        Random rnd = new Random();

        public Company(string name)
        {
            Id = rnd.Next(1000000, 9999999);
            Name = name;
            IsActive = true;
        }
    }

}
