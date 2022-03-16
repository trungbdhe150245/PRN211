using OTS.DAO;
using OTS.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS.Login
{
    public partial class FrmLoginStudent : Form
    {
        public FrmLoginStudent()
        {
            InitializeComponent();
        }
        private bool ValidateLogin()
        {
            string mess = "";
            if(txtUsername.Text.Equals(""))
            {
                mess = "Username cannot empty";
            } else if (txtPassword.Text.Equals(""))
            {
                mess = "Password cannot empty";
            }

            if (mess.Equals(""))
            {
                return true;
            } else
            {
                MessageBox.Show(mess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateLogin())
            {
                StudentDBContext dbStudent = new StudentDBContext();
                if (dbStudent.GetStudent(txtUsername.Text, txtPassword.Text) != null)
                {
                    FrmStudentDashboard frmStudentDashboard = new FrmStudentDashboard();
                    frmStudentDashboard.Show();
                    this.Hide();
                }
            }
            

        }
    }
}
