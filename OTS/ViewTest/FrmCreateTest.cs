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
        SubjectDBContext subjectDBContext = new SubjectDBContext();
        TestDBContext testDBContext = new TestDBContext();
        TypeDBContext typeDBContext = new TypeDBContext();
        QuestionDBContext questionDBContext = new QuestionDBContext();
        //private void InitCustomStyle()
        //{
        //    dtpStartTime.Format = DateTimePickerFormat.Custom;
        //    dtpStartTime.CustomFormat = "HH:mm:ss";
        //    dtpTestDate.Format = DateTimePickerFormat.Custom;
        //    dtpTestDate.CustomFormat = "dd/MM/yyyy";
        //    dtpDuration.Format = DateTimePickerFormat.Time;
        //    dtpDuration.CustomFormat = "HH:mm:ss";
        //    dtpStartTime.Format = DateTimePickerFormat.Time;
        //    dtpStartTime.CustomFormat = "HH:mm:ss";
        //}

        private void LoadSubject()
        {
            List<Subject> subjects = subjectDBContext.GetSubjects();
            cbSubject.DataSource = subjects;
            cbSubject.ValueMember = "SubjectCode";
            cbSubject.DisplayMember = "SubjectName";

        }

        private void LoadTest()
        {
            List<Test> tests = testDBContext.GetTests();
            dgvTest.DataSource = tests;
        }

        private void LoadType()
        {
            List<Models.Type> types = typeDBContext.GetType();
            cbType.DataSource = types;
            cbType.ValueMember = "Id";
            cbType.DisplayMember = "Name";

        }

        private bool CheckInput()
        {
            string mess = "";

            if (txtTotalQuest.Text.Equals(""))
            {
                mess = "You must select number of questions";
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


        private void LoadTotal()
        {
            int total = GetTotal((int)nudEasy.Value, (int)nudMedium.Value, (int)nudHard.Value);
            if (total > 0)
            {
                txtTotalQuest.Text = total.ToString();
            }
        }

        private int GetTotal(int easy, int medium, int hard)
        {
            int total = 0;
            if (easy + medium + hard > 0)
            {
                total = easy + medium + hard;
            }
            return total;
        }

        private int GenEasyQuest(short type, string code, int test)
        {
            int level = 1;
            int row = 0;
            List<Question> questions = questionDBContext.GetRandomQuestions(type, level, code);
            if(nudEasy.Value <= questions.Count)
            {
                questions.ToArray();
                for (int i = 0; i < int.Parse(nudEasy.Value.ToString()); i++)
                {
                    row = questionDBContext.InsertQuestion_Test(questions[i].Id, test);
                }
            }
            else
            {
                MessageBox.Show("Ran out of Easy question for this Subject");
            }
            return row;
        }

        private int GenMedQuest(short type, string code, int test)
        {
            int level = 2;
            int row = 0;
            List<Question> questions = questionDBContext.GetRandomQuestions(type, level, code);
            if (nudMedium.Value <= questions.Count)
            {
                questions.ToArray();
                for (int i = 0; i < int.Parse(nudMedium.Value.ToString()); i++)
                {
                    row = questionDBContext.InsertQuestion_Test(questions[i].Id, test);
                }
            }
            else
            {
                MessageBox.Show("Ran out of Medium question for this Subject");
            }
            return row;
        }

        private int GenHardQuest(short type, string code, int test)
        {
            int level = 3;
            int row = 0;
            List<Question> questions = questionDBContext.GetRandomQuestions(type, level, code);
            if (nudHard.Value <= questions.Count)
            {
                questions.ToArray();
                for (int i = 0; i < int.Parse(nudHard.Value.ToString()); i++)
                {
                    row = questionDBContext.InsertQuestion_Test(questions[i].Id, test);
                }
            }
            else
            {
                MessageBox.Show("Ran out of Hard question for this Subject");
            }
            return row;
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
                    CreateDate = DateTime.Now.Date,
                    EndTime = TimeSpan.Parse(dtpEndTime.Text),
                    IsReview = checkReview.Checked,
                };
                Subject s = (Subject)cbSubject.SelectedItem;
                Subject subject = subjectDBContext.GetSubject(s.SubjectCode.Trim());
                test.Subject = subject;
                int row = testDBContext.InsertTest(test);

                int testId = testDBContext.GetLatestTestId();

                int easy = GenEasyQuest((Int16)cbType.SelectedValue, cbSubject.SelectedValue.ToString(), testId);
                int med = GenMedQuest((Int16)cbType.SelectedValue, cbSubject.SelectedValue.ToString(), testId);
                int hard = GenHardQuest((Int16)cbType.SelectedValue, cbSubject.SelectedValue.ToString(), testId);
                if (!(row > 0 && easy > 0 && med > 0 && hard > 0))
                {
                    testDBContext.DeleteTest(testId);
                    MessageBox.Show("Create failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadTest();
                }
                else
                {
                    MessageBox.Show("Create successful");
                    LoadTest();
                    txtTestCode.Text = "";
                    dtpTestDate.Value = DateTime.Now;
                    cbSubject.SelectedIndex = 0;
                    cbType.SelectedIndex = 0;
                    nudEasy.Value = 0;
                    nudMedium.Value = 0;
                    nudHard.Value = 0;
                    checkReview.Checked = false;
                }

            }
        }

        private void FrmCreateTest_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSubject();
                LoadTest();
                LoadType();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        private void nudEasy_ValueChanged(object sender, EventArgs e)
        {
            LoadTotal();
        }

        private void nudMedium_ValueChanged(object sender, EventArgs e)
        {
            LoadTotal();
        }

        private void nudHard_ValueChanged(object sender, EventArgs e)
        {
            LoadTotal();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel!\nAll change will be canceled", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
                
        }
    }
}
