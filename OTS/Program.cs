using OTS.DAO;
using OTS.Login;
using OTS.ManageMark;
using OTS.ManageQuestion;
using OTS.StudenDashBoard;
using OTS.ManageSubmission;
using OTS.Models;
using OTS.ReviewSubmission;
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
            //Application.Run(new FrmViewTest(10));
            //Application.Run(new ManageSubject.InsertSubject());
            //Application.Run(new ManageSubject.UpdateSubject());
            //Application.Run(new ManageTest.frmManageTest());
            //Application.Run(new FrmManageClass());
            //Application.Run(new FrmViewTest(3));
            //Application.Run(new FrmReviewSubmission(34, 8));
            //Application.Run(new FrmManageMark());
            //Application.Run(new FrmLoginStudent());
            Application.Run(new ListQuestionBank());
        }
    }
}
