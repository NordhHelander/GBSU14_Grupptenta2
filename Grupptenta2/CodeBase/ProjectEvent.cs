using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
    public class ProjectEvent
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public BindingList<Note> Notes { get; set; }
        // public string Type { get; set; }

		public ProjectEvent()
		{
			Notes = new BindingList<Note>();
		}

		public override string ToString()
		{
			return StartDate.ToShortDateString() + ": " + Name;
		}
    }
}
