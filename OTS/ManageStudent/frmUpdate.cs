using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OTS.DAO;
using OTS.Models;

namespace OTS.ManageStudent
{
    public partial class frmUpdate : Form
    {
        Int32 oldId = 0;
        String oldFullName = "";
        String oldPassword = "";
        DateTime oldDob;
        String oldStudentCode = "";
        String oldClassCode = "";
        StudentDBContext studentDBContext;
        Student studentDB;
        public frmUpdate(Int32 Id)
        {
            
            oldId=Id;           
            InitializeComponent();
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            loadStudent();
        }

        private void loadStudent()
        {
            studentDB= studentDBContext.GetStudent(oldId);
            txtFullName.Text = studentDB.FullName;
            txtClassCode.Text=studentDB.Class.ClassCode.ToString();
            txtPassword.Text = studentDB.Password;
            dtpDob.Value = studentDB.DateOfBirth;
            txtPassword.Text = studentDB.StudentCode;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
