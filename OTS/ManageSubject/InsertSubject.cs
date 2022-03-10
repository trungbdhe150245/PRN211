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
    public partial class InsertSubject : Form
    {
        String subjectCode = "";
        String subjectName = "";
        String rgxsubjectCode = "^[a-zA-Z0-9]{2,50}$";
        String rgxsubjectName = "^[a-zA-Z0-9]{2,255}$";

        public InsertSubject()
        {
            InitializeComponent();
        }

        private void InsertSubject_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SubjectDBContext subjectDBC = new SubjectDBContext();
            do
            {
                try
                {
                    subjectCode = txtSubjectCode.Text;
                    subjectName = txtSubjectName.Text;
                    if (Regex.IsMatch(subjectCode, rgxsubjectCode)&&!String.IsNullOrEmpty(subjectCode))
                    {
                        if (Regex.IsMatch(subjectName, rgxsubjectName)&&!String.IsNullOrEmpty(subjectName))
                        {
                            break;
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
                    break;
                }

            } while (true);
            subjectDBC.InsertSubject(subjectCode,subjectName);
        }
    }
}
//try
//{
//    SubjectDBContext subjectDBContext = new SubjectDBContext();
//    dgvClasses.DataSource = subjectDBContext.getClasses(querySearch, "name");
//}
//catch (Exception ex)
//{
//    MessageBox.Show(ex.Message);
//}