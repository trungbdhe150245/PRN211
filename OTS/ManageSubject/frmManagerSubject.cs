using OTS.DAO;
using OTS.ManageSubject;
using OTS.Models;
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

namespace OTS.ManageSubject
{
    public partial class frmManagerSubject : Form
    {
        String subjectCode = "";
        String subjectName = "";       
        String option = "";
        String rgxsubjectCode = "^[a-zA-Z0-9]{2,50}$";
        String rgxsubjectName = "^[a-zA-Z0-9 .-]{2,255}$";
        ManageSubject.frmInsert insert=new ManageSubject.frmInsert();
        ManageSubject.frmUpdate update = new ManageSubject.frmUpdate();
        SubjectDBContext subjectDBContext = new SubjectDBContext();
        

        public frmManagerSubject()
        {
            InitializeComponent();
            
        }
        Subject target = null;
        private void ClearData()
        {
            dgvManageSubject.Rows.Clear();
            txtSubjectCode.Text = "";
            txtSubjectName.Text = "";           
            target = null;
        }
        public String getOption(String subjectCode,String subjectName)
        {
            String result = "";
            if (!String.IsNullOrEmpty(subjectCode)&& String.IsNullOrEmpty(subjectName))
            {
                result = "FindBySubjectCode";
            } else if (!String.IsNullOrEmpty(subjectName) && String.IsNullOrEmpty(subjectCode))
            {
                result = "FindBySubjectName";
            }else if(!String.IsNullOrEmpty(subjectName) && !String.IsNullOrEmpty(subjectCode)){
                result = "FindBySubjectCodeAndName";
            }
            else
            {
                result = "getAll";
            }
            return result;
        }
        
        private void LoadSubject(String option)
        {
            
            var subjectss = new DAO.SubjectDBContext().FindSubject(option,subjectCode,subjectName).ToList();
            foreach(var s in subjectss)
            {
                dgvManageSubject.Rows.Add(s.SubjectCode,s.SubjectName);
            }            
            
        }
        private void ManagerSubject_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSubject("getAll");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            
            SubjectDBContext subjectDBC = new SubjectDBContext();
            try
            {
                subjectCode = txtSubjectCode.Text;
                subjectName = txtSubjectName.Text;
                option=getOption(subjectCode,subjectName);
                if (!String.IsNullOrEmpty(option))
                {
                    ClearData();
                    LoadSubject(option);
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Value", "Warnning",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {                
                insert.Show();
                LoadSubject("getAll");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                update.Show();
                LoadSubject("getAll");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvManageSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvManageSubject.SelectedRows[0];

            String subjectCode =row.Cells[0].Value.ToString();
            String subjectName = row.Cells[1].Value.ToString();
            target = subjectDBContext.GetSubject("FindBySubjectCode", subjectCode, subjectName);
            if (target != null)
            {
                txtSubjectCode.Text = target.SubjectCode.ToString();
                txtSubjectName.Text = target.SubjectName.ToString();
                

            }
            
        }
    }
}
