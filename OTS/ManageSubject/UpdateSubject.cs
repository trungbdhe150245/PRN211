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
        String rgxsubjectName = "^[a-zA-Z0-9]{2,255}$";
        public UpdateSubject()
        {
            InitializeComponent();
        }

        private void UpdateSubject_Load(object sender, EventArgs e)
        {



            try
            {
                LoadSubject();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void LoadSubject()
        {


            List<Models.Subject> subject=new DAO.SubjectDBContext().Getsubjects();
            
            try
            {
                SubjectDBContext subjectDBContext = new SubjectDBContext();
                gdvUpdateSubject.DataSource = subjectDBContext.Getsubjects();
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
                if (Regex.IsMatch(oldsubjectCode, rgxsubjectCode) && !String.IsNullOrEmpty(oldsubjectCode) && String.IsNullOrEmpty(oldsubjectName))
                {
                    option = "FindBySubjectCode";

                    UpdateSubject_Load(option, oldsubjectCode, oldsubjectName, gdvUpdateSubject, sender, e);
                }
                else if (Regex.IsMatch(oldsubjectName, rgxsubjectName) && !String.IsNullOrEmpty(oldsubjectName) && String.IsNullOrEmpty(oldsubjectCode))
                {
                    option = "FindBySubjectName";
                    subjectDBC.FindSubject(option, oldsubjectCode, oldsubjectName, gdvUpdateSubject);
                }
                else
                {
                    if (Regex.IsMatch(oldsubjectCode, rgxsubjectCode) && !String.IsNullOrEmpty(oldsubjectCode))
                    {
                        if (Regex.IsMatch(oldsubjectName, rgxsubjectName) && !String.IsNullOrEmpty(oldsubjectName))
                        {
                            option = "FindBySubjectCodeAndName";
                            subjectDBC.FindSubject(option, oldsubjectCode, oldsubjectName, gdvUpdateSubject);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Value", "Warnning",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SubjectDBContext subjectDBC = new SubjectDBContext();

            try
            {
                oldsubjectCode = txtSubjectCode.Text;
                oldsubjectName = txtSubjectName.Text;
                newsubjectCode = txtNewSubjectCode.Text;
                newsubjectName = txtNewSubjectName.Text;
                if (Regex.IsMatch(oldsubjectCode, rgxsubjectCode) && !String.IsNullOrEmpty(oldsubjectCode))
                {
                    if (Regex.IsMatch(oldsubjectName, rgxsubjectName) && !String.IsNullOrEmpty(oldsubjectName))
                    {
                        if (Regex.IsMatch(newsubjectCode, rgxsubjectCode) && !String.IsNullOrEmpty(newsubjectCode))
                        {
                            if (Regex.IsMatch(newsubjectName, rgxsubjectName) && !String.IsNullOrEmpty(newsubjectName))
                            {
                                subjectDBC.UpdateSubject(oldsubjectCode, oldsubjectName, newsubjectCode, newsubjectName);
                            }
                        }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
