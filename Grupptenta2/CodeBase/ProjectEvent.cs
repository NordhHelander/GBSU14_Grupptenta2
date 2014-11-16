using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
    public class ProjectEvent
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public List<Note> Notes { get; set; }
        // public string Type { get; set; }

		public override string ToString()
		{
			return StartDate.ToShortDateString() + ": " + Name;
		}
    }
}
