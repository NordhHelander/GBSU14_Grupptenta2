﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupptenta2
{
	public partial class PersonUserControl : UserControl
	{
		public Action ShowPersonControl { get; private set;}

		public PersonUserControl()
		{
			InitializeComponent();
		}
	}
}
