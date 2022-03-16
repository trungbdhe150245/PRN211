using OTS.DAO;
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
    public partial class UpdateSubject : Form
    {
        String newsubjectCode = "";
        String newsubjectName = "";
        String oldsubjectCode = "";
        String oldsubjectName = "";
        String option = "";
        String rgxsubjectCode = "^[a-zA-Z0-9]{2,50}$";
        String rgxsubjectName = "^[a-zA-Z0-9 ]{2,255}$";
        public UpdateSubject()
        {
            InitializeComponent();
        }
        public String getOption(object sender, EventArgs e)
        {
            try
            {
                oldsubjectCode = txtSubjectCode.Text;
                oldsubjectName = txtSubjectName.Text;
                if (Regex.IsMatch(oldsubjectCode, rgxsubjectCode) && !String.IsNullOrEmpty(oldsubjectCode) && String.IsNullOrEmpty(oldsubjectName))
                {
                    option = "FindBySubjectCode";
                    UpdateSubject_Load(option, oldsubjectCode, oldsubjectName, sender, e);
                }
                else if (Regex.IsMatch(oldsubjectName, rgxsubjectName) && !String.IsNullOrEmpty(oldsubjectName) && String.IsNullOrEmpty(oldsubjectCode))
                {
                    option = "FindBySubjectName";
                    UpdateSubject_Load(option, oldsubjectCode, oldsubjectName, sender, e);
                }
                else
                {
                    if (Regex.IsMatch(oldsubjectCode, rgxsubjectCode) && !String.IsNullOrEmpty(oldsubjectCode))
                    {
                        if (Regex.IsMatch(oldsubjectName, rgxsubjectName) && !String.IsNullOrEmpty(oldsubjectName))
                        {
                            option = "FindBySubjectCodeAndName";
                            UpdateSubject_Load(option, oldsubjectCode, oldsubjectName, sender, e);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Value", "Warnning",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return option;
        }

        private void UpdateSubject_Load(String option, String subjectCode, String subjectName, object sender, EventArgs e)
        {

            try
            {
                LoadSubject(option, subjectCode, subjectName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void LoadSubject(String option, String subjectCode, String subjectName)
        {


            List<Models.Subject> subject = new DAO.SubjectDBContext().Getsubjects();

            try
            {
                SubjectDBContext subjectDBContext = new SubjectDBContext();
                gdvUpdateSubject.DataSource = subjectDBContext.FindSubject(option, subjectCode, subjectName);
                gdvUpdateSubject.AutoGenerateColumns = false;
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
                oldsubjectCode = txtSubjectCode.Text;
                oldsubjectName = txtSubjectName.Text;
                option = getOption(sender, e);
                if (option == "FindBySubjectCode")
                {
                    UpdateSubject_Load(option, oldsubjectCode, oldsubjectName, sender, e);
                }
                else if (option == "FindBySubjectName")
                {
                    UpdateSubject_Load(option, oldsubjectCode, oldsubjectName, sender, e);
                }
                else if (option == "FindBySubjectCodeAndName")
                {
                    UpdateSubject_Load(option, oldsubjectCode, oldsubjectName, sender, e);
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

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            SubjectDBContext subjectDBC = new SubjectDBContext();
            int rowefect = 0;
            option = getOption(sender, e);
            try
            {
                oldsubjectCode = txtSubjectCode.Text;
                oldsubjectName = txtSubjectName.Text;
                newsubjectCode = txtNewSubjectCode.Text;
                newsubjectName = txtNewSubjectName.Text;


                if (option.Length > 0)
                {
                    rowefect = subjectDBC.UpdateSubject(option, oldsubjectCode, oldsubjectName, newsubjectCode, newsubjectName);
                   
                    if (rowefect > 0)
                    {
                        MessageBox.Show("Update sucessfull", "Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
    }
}
