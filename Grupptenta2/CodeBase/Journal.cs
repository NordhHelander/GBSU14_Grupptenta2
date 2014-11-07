using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
    public class Journal
    {
        public List<Note> Notes { get; set; }
        public List<ProjectEvent> Events { get; set; }
    }
}
