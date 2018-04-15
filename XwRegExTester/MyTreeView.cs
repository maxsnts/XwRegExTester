using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace XwRegExTester
{
	public class MyTreeView : TreeView
	{
		private const int TVS_NOTOOLTIPS = 0x80;
		protected override System.Windows.Forms.CreateParams CreateParams
		{
			get
			{
				CreateParams p = base.CreateParams;
				p.Style = p.Style | TVS_NOTOOLTIPS;
				return p;
			}
		}
	}
}
