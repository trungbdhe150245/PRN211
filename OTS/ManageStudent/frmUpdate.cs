using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using OTS.DAO;
using OTS.Models;

namespace OTS.ManageStudent
{
    public partial class frmUpdate : Form
    {
        Int32 rowefect = 0;
        Int32 oldId = 0;
        String oldFullName = "";
        String oldPassword = "";
        DateTime oldDob;
        String oldStudentCode = "";
        String oldClassCode = "";

        String newFullName = "";
        String newPassword = "";
        DateTime newDob;
        String newStudentCode = "";
        String newClassCode = "";
        StudentDBContext studentDBContext;
        Student target = null;
        String rgxName = "^[a-zA-Z0-9 .-]{2,255}$";
        String rgxPassword = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,40}$";
        String rgxStudentCode = "^[a-zA-Z0-9]{2,50}$";
        public frmUpdate(Int32 Id)
        {
            InitializeComponent();
            oldId = Id;
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            loadStudent(oldId);
        }

        private void loadStudent(Int32 old)
        {
            target = new Student();
            studentDBContext = new StudentDBContext();
            target = studentDBContext.GetStudent(oldId);
            txtFullName.Text = target.FullName.Trim();
            txtClassCode.Text = target.Class.ClassCode.Trim();
            txtPassword.Text = target.Password.Trim();
            dtpDob.Value = target.DateOfBirth;
            txtPassword.Text = target.Password.Trim();
            txtStudentCode.Text = target.StudentCode.Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            oldFullName = target.FullName.Trim();
            oldClassCode = target.Class.ClassCode.Trim();
            oldDob = target.DateOfBirth.Date;
            oldPassword = target.Password.Trim();
            oldStudentCode = target.StudentCode.Trim();
            studentDBContext = new StudentDBContext();

            newFullName = txtFullName.Text.ToString().Trim();
            newPassword = txtPassword.Text.ToString().Trim();
            newDob = dtpDob.Value;
            newStudentCode = txtStudentCode.Text.ToString().Trim();
            newClassCode = txtClassCode.Text.ToString().Trim();

            if (Regex.IsMatch(newFullName, rgxName))
            {
                if (Regex.IsMatch(newPassword, rgxPassword))
                {

                    if (Regex.IsMatch(newStudentCode, rgxStudentCode))
                    {
                        if (Regex.IsMatch(newClassCode, rgxStudentCode))
                        {
                             rowefect = studentDBContext.UpdateStudent(target.Id.ToString().Trim(), newFullName, newPassword, newDob, newStudentCode, newClassCode);
                        }
                        else
                        {
                            MessageBox.Show("ClassCode invalid value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("StudentCode invalid value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Password is Malformed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("FullName invalid value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





            if (rowefect > 0)
            {
                MessageBox.Show("Update sucessfull!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            rowefect = 0;
        }
    }
}
