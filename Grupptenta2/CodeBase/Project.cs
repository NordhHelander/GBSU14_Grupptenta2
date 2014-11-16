using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
    [Serializable]
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
		public string Description { get; set; }
        public Journal ProjectJournal { get; set; }
        public BindingList<Note> Notes { get; set; }
        public BindingList<Person> Roles { get; set; }
        public bool IsActive { get; set; }

        public Project()
        {

        }

    }
}
