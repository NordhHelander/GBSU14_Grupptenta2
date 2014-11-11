using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
    public class Meeting : ProjectEvent
    {
        public Address Location { get; set; }
        public List<Person> Attendees { get; set; }

    }
}
