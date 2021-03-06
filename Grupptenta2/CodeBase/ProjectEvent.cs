﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
    [Serializable]
    public class ProjectEvent
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public BindingList<Note> Notes { get; set; }
        public Address Location { get; set; }
        public BindingList<Person> Participants { get; set; }

		public ProjectEvent()
		{
			Notes = new BindingList<Note>();
			Participants = new BindingList<Person>();
			Location = new Address();
		}

		public override string ToString()
		{
			return StartDate.ToShortDateString() + ": " + Name;
		}
    }
}
