using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Journal ProjectJournal { get; set; }
        public List<Note> Notes { get; set; }
        public List<string> Roles { get; set; }
        public bool IsActive { get; set; }
    }
}
