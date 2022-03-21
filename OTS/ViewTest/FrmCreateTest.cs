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
        }

        private void LoadTest()
        {
            TestDBContext testDBContext = new TestDBContext();
            List<Test> tests = testDBContext.GetTests();
            //nudQuestions.DataBindings.Clear();
            //nudEasy.DataBindings.Clear();
            //nudMedium.DataBindings.Clear();
            //nudHard.DataBindings.Clear();
            //dtpTestDate.DataBindings.Clear();
            //cbSubjectCode.DataBindings.Clear();
            //cbClassCode.DataBindings.Clear();
            //dtpStartTime.DataBindings.Clear();
            //checkReview.DataBindings.Clear();
            //dtpDuration.DataBindings.Clear();

            //nudQuestions.DataBindings.Clear();
            //nudEasy.DataBindings.Clear();
            //nudMedium.DataBindings.Clear();
            //nudHard.DataBindings.Clear();
            //dtpTestDate.DataBindings.Clear();
            //cbSubjectCode.DataBindings.Clear();
            //cbClassCode.DataBindings.Clear();
            //dtpStartTime.DataBindings.Clear();
            //checkReview.DataBindings.Clear();
            //dtpDuration.DataBindings.Clear();

            dgvTest.DataSource = tests;
        }

        private void LoadClass()
        {
            ClassDBContext classDBContext = new ClassDBContext();
            List<Class> classes = classDBContext.GetClasses();
            foreach (Class c in classes)
            {
                cbClass.DisplayMember = c.ClassName;
                cbClass.ValueMember = c.ClassCode;
            }
            cbClass.DataSource = classes;
        }

        private bool CheckInput()
        {
            string mess = "";
            if (nudQuestions.Value == 0)
            {
                mess = "Questions cannot empty";
            } else if (dtpTestDate.Value.CompareTo(DateTime.Now) < 0)
            {
                mess = "Invalid Test Date";
            } else if (cbSubject.Text.Equals(""))
            {
                mess = "Subject Code cannot empty";
            } else if (cbClass.Text.Equals(""))
            {
                mess = "Class Name cannot empty";
            }

            if (mess.Equals(""))
            {
                return true;
            } else
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
                    Code = cbClass.Text,
                    StartTime = TimeSpan.Parse(dtpStartTime.Text),
                    TestDate = DateTime.Parse(dtpTestDate.Text),
                    Duration = TimeSpan.Parse(dtpDuration.Text),
                    CreateDate = DateTime.Now,
                    IsReview = checkReview.Checked,
                };
                SubjectDBContext subjectDBContext = new SubjectDBContext();
                Subject subject = subjectDBContext.GetSubject(cbSubject.Text);
                test.Subject = subject;

                TestDBContext testDBContext = new TestDBContext();
                testDBContext.InsertTest(test);
                MessageBox.Show("Create successful");
                LoadTest();

            }
        }

        private void FrmCreateTest_Load(object sender, EventArgs e)
        {
            LoadClass();
        }
    }
}
