using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
	public class Note
	{
		public DateTime NoteDate { get; set; }
		public string Text { get; set; }

		public override string ToString()
		{
			return NoteDate.ToShortDateString() + ": " + Text;
		}
	}
}
