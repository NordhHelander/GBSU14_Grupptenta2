using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
    public class Journal
    {
        public BindingList<Note> Notes { get; set; }
        public BindingList<ProjectEvent> Events { get; set; }

		public Journal()
		{
			Notes = new BindingList<Note>();
			Events = new BindingList<ProjectEvent>();
		}
    }
}
