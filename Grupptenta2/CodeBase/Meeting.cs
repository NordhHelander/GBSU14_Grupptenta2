﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
    [Serializable]
    public class Meeting
    {
        public Address Location { get; set; }
        public BindingList<Person> Participants { get; set; }

		public Meeting()
		{
			Participants = new BindingList<Person>();
		}
    }
}
