using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeBase
{
    [Serializable]
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Location { get; set; }
        //[XmlIgnore]
        public BindingList<Person> Employees { get; set; }
        //[XmlIgnore]
        public List<Project> Projects { get; set; }    
        public bool IsActive { get; set; }

        Random rnd = new Random();

        public Company()
        {

        }

        public Company(string name)
        {
            Id = rnd.Next(1, 10000);
            Name = name;
            IsActive = true;

            Employees = new BindingList<Person>();
        }

    }

}
