using OTS.ManageQuestion;
using OTS.StudenDashBoard;
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
            //Application.Run(new FrmViewTest(new Models.Test() { }));
            //Application.Run(new ListQuestionBank());
            Application.Run(new StudentDashBoard());

        }
    }
}
