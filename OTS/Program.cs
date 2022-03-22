using OTS.ManageQuestion;
using OTS.ViewTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new FrmManageClass());
			//Application.Run(new FrmViewTest());
			//Application.Run(new ManageSubject.InsertSubject());
			//Application.Run(new ManageSubject.UpdateSubject());
			Application.Run(new ManageSubject.frmManagerSubject());

		}
	}
}
