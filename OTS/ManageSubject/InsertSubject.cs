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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SubjectDBContext subjectDBC = new SubjectDBContext();
            
                try
                {
                    subjectCode = txtSubjectCode.Text;
                    subjectName = txtSubjectName.Text;
                    if (Regex.IsMatch(subjectCode, rgxsubjectCode)&&!String.IsNullOrEmpty(subjectCode))
                    {
                        if (Regex.IsMatch(subjectName, rgxsubjectName)&&!String.IsNullOrEmpty(subjectName))
                        {
                        subjectDBC.InsertSubject(subjectCode, subjectName);
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
