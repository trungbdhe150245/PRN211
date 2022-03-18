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
    public partial class DeleteSubject : Form
    {
        String option = "";
        String subjectCode = "";
        String subjectName = "";
        String rgxsubjectCode = "^[a-zA-Z0-9]{2,50}$";
        String rgxsubjectName = "^[a-zA-Z0-9 ]{2,255}$";
        public String getOption(String option, object sender, EventArgs e)
        {
            try
            {
                subjectCode = txtSubjectCode.Text;
                subjectName = txtSubjectName.Text;
                if (Regex.IsMatch(subjectCode, rgxsubjectCode) && !String.IsNullOrEmpty(subjectCode) && String.IsNullOrEmpty(subjectName))
                {
                    option = "FindBySubjectCode";
                }
                else if (Regex.IsMatch(subjectName, rgxsubjectName) && !String.IsNullOrEmpty(subjectName) && String.IsNullOrEmpty(subjectCode))
                {
                    option = "FindBySubjectName";
                }
                else
                {
                    if (Regex.IsMatch(subjectCode, rgxsubjectCode) && !String.IsNullOrEmpty(subjectCode))
                    {
                        if (Regex.IsMatch(subjectName, rgxsubjectName) && !String.IsNullOrEmpty(subjectName))
                        {
                            option = "FindBySubjectCodeAndName";
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
        private void LoadSubject(String option, String subjectCode, String subjectName)
        {


            List<Models.Subject> subject = new DAO.SubjectDBContext().Getsubjects();

            try
            {
                SubjectDBContext subjectDBContext = new SubjectDBContext();
                gdvDeleteSubject.DataSource = subjectDBContext.FindSubject(option, subjectCode, subjectName);
                gdvDeleteSubject.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DeleteSubject()
        {
            InitializeComponent();
        }

        private void DeleteSubject_Load(String option, object sender, EventArgs e)
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
        private void btnFind_Click(object sender, EventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
