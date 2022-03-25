using OTS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS.ManageStudent
{
    public partial class frmManageStudent : Form
    {
        String classCode = "";
        String studentName = "";
        String option = "";
        String rgxsubjectCode = "^[a-zA-Z0-9]{2,50}$";
        String rgxsubjectName = "^[a-zA-Z0-9 .-]{2,255}$";
        int rowselected = 0;
        StudentDBContext studentDBContext;
        public frmManageStudent()
        {
            InitializeComponent();
        }

        private void frmManageStudent_Load(object sender, EventArgs e)
        {
            try
            {
                LoadStudent("getAll");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadStudent(string option)
{
            studentDBContext = new StudentDBContext();
            var students = new DAO.StudentDBContext().FindStudent(option, classCode, studentName).ToList();
            foreach (var s in students)
            {
                dgvStudent.Rows.Add(s.Id,s.FullName,s.Password,s.DateOfBirth,s.StudentCode,s.Class.ClassCode);
            }
        }
    }
}
