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
    public partial class frmInsertStudent : Form
    {
        int Id = 0;
        String FullName = "";
        String Password = "";
        DateTime Dob;
        String StudentCode = "";
        String ClassCode = "";
        DAO.StudentDBContext student;
        
        

        public frmInsertStudent()
        {
            InitializeComponent();

        }
        void fillClassCode (){
            List<Models.Class> classDB = new List<Models.Class>();
            classDB =student.getClassCode();

            foreach (Class code in classDB)
            {
                comboxClassCode.Items.Add(code.ClassCode);
            }
         }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StudentDBContext    studentDBContext=new StudentDBContext();
            try
            {
                 
                 FullName = txtFullName.Text.Trim();
                 Password = txtPassword.Text.Trim();
                 Dob=dtPDob.Value;
                 StudentCode =txtStudentCode.Text.Trim();
                //  ClassCode = txtClassCode.Text.Trim();
                

                studentDBContext.InsertStudent( FullName, Password, Dob, StudentCode, ClassCode);


            }
            catch (Exception ex)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmInsertStudent_Load(object sender, EventArgs e)
        {
            fillClassCode();
        }
    }
}
