using OTS.DAO;
using OTS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS.ViewTest
{
    public partial class FrmCreateTest : Form
    {
        public FrmCreateTest()
        {
            InitializeComponent();
            //InitCustomStyle();
        }

        private void InitCustomStyle()
        {
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "HH:mm:ss";
            dtpTestDate.Format = DateTimePickerFormat.Custom;
            dtpTestDate.CustomFormat = "dd/MM/yyyy";
            dtpDuration.Format = DateTimePickerFormat.Time;
            dtpDuration.CustomFormat = "HH:mm:ss";
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.CustomFormat = "HH:mm:ss";
        }

        private void LoadSubject()
        {
            SubjectDBContext subjectDBContext = new SubjectDBContext();
            List<Subject> subjects = subjectDBContext.Getsubjects();
            
            cbSubject.ValueMember = "SubjectCode";
            cbSubject.DisplayMember = "SubjectName";
            cbSubject.DataSource = subjects;
        }

        private void LoadTest()
        {
            TestDBContext testDBContext = new TestDBContext();
            List<Test> tests = testDBContext.GetTests();

            //nudQuestions.DataBindings.Clear();
            //nudEasy.DataBindings.Clear();
            //nudMedium.DataBindings.Clear();
            //nudHard.DataBindings.Clear();
            //txtTestCode.DataBindings.Clear();
            //dtpTestDate.DataBindings.Clear();
            //cbSubject.DataBindings.Clear();
            //dtpStartTime.DataBindings.Clear();
            //checkReview.DataBindings.Clear();
            //dtpDuration.DataBindings.Clear();



            dgvTest.DataSource = tests;
        }


        private bool CheckInput()
        {
            string mess = "";
            if (nudQuestions.Value == 0)
            {
                mess = "Questions cannot empty";
            }
            else if (txtTestCode.Text.Equals(""))
            {
                mess = "Test Code cannot empty";
            }
            else if (dtpTestDate.Value.CompareTo(DateTime.Now) < 0)
            {
                mess = "Invalid Test Date";
            }
            else if (cbSubject.Text.Equals(""))
            {
                mess = "Subject Code cannot empty";
            }

            if (mess.Equals(""))
            {
                return true;
            }
            else
            {
                MessageBox.Show(mess, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                Test test = new Test()
                {
                    Code = txtTestCode.Text,
                    StartTime = TimeSpan.Parse(dtpStartTime.Text),
                    TestDate = DateTime.Parse(dtpTestDate.Text),
                    Duration = TimeSpan.Parse(dtpDuration.Text),
                    CreateDate = DateTime.Now,
                    EndTime = TimeSpan.Parse(dtpEndTime.Text),
                    IsReview = checkReview.Checked,
                };
                SubjectDBContext subjectDBContext = new SubjectDBContext();
                Subject s = (Subject)cbSubject.SelectedItem;
                Subject subject = subjectDBContext.GetSubject(s.SubjectCode.Trim());
                test.Subject = subject;

                TestDBContext testDBContext = new TestDBContext();
                testDBContext.InsertTest(test);
                MessageBox.Show("Create successful");
                LoadTest();
            }
        }

        private void FrmCreateTest_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSubject();
                LoadTest();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
