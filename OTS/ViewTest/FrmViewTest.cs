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
    public partial class FrmViewTest : Form
    {
        private int testID;
        public FrmViewTest(int testID)
        {
            this.testID = testID;
            InitializeComponent();

            InitCustomStyle();
        }

        private void InitCustomStyle()
        {
            dtpCreateDate.Format = DateTimePickerFormat.Custom;
            dtpCreateDate.CustomFormat = "dd/MM/yyyy";
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "HH:mm:ss";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpDuration.Format = DateTimePickerFormat.Time;
            dtpDuration.CustomFormat = "HH:mm:ss";
        }
        public void LoadQuestionsList()
        {
            try
            {
                QuestionDBContext questionDBC = new QuestionDBContext();
                foreach (QuestionTest questionTest in questionDBC.GetQuestionByTests(testID))
                {
                    dgvQuestion.Rows.Add(
                        questionTest.Question.Id,
                        questionTest.Question.Content,
                        questionTest.Question.Type.Name,
                        questionTest.Question.Level.Name,
                        "View",
                         "Change"
                        );
                }
                txtTotalQuestion.Text = dgvQuestion.Rows.Count.ToString();
                //dgvQuestion.DataSource = questionTestDisplays;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void LoadTestInformation()
        {
            try
            {
                TestDBContext testDBC = new TestDBContext();
                Test test = testDBC.GetTest(testID);
                if (test != null)
                {
                    txtTestID.Text = test.Id.ToString();
                    txtTestCode.Text = test.Code;
                    txtSubject.Text = test.Subject.SubjectCode
                        + " - " + test.Subject.SubjectName;
                    dtpCreateDate.Value = test.CreateDate;
                    dtpStartDate.Value = test.TestDate;
                    DateTime dt = new DateTime(2022, 12, 31);
                    dtpStartTime.Value = dt.Add(test.StartTime);
                    dtpDuration.Value = dt.Add(test.Duration);
                    cbReview.Checked = test.IsReview;
                    LoadQuestionsList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void FrmViewTest_Load(object sender, EventArgs e)
        {
            LoadTestInformation();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvQuestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridViewQuestion = (DataGridView)sender;
            if (e.ColumnIndex == 5 && e.RowIndex != -1)
            {
                try
                {
                    int selectedQuestionId = Int32.Parse(
                        dataGridViewQuestion.Rows[e.RowIndex].Cells["QuestionID"].Value.ToString());

                    QuestionDBContext questionDBC = new QuestionDBContext();
                    Question selectedQuestion = questionDBC.GetQuestion(selectedQuestionId);
                    if (selectedQuestion != null)
                    {

                        Question newQuestion = null;
                        bool isFindAnother = false;
                        //do
                        //{
                        newQuestion = questionDBC.GetRandomQuestionWithLevel(selectedQuestion.Level.Id, selectedQuestion.Subject.SubjectCode);
                        foreach (DataGridViewRow row in dgvQuestion.Rows)
                        {
                            if (
                            Int32.Parse(row.Cells["QuestionID"].Value.ToString()) == newQuestion.Id)
                            {
                                isFindAnother = true;
                            };
                        }
                        //} while (isFindAnother);
                        if (newQuestion != null)
                        {

                            dataGridViewQuestion.Rows[e.RowIndex].SetValues(newQuestion.Id, newQuestion.Content, newQuestion.Type.Name, newQuestion.Level.Name, "View", "Change");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Question not found", "Error");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTestCode.Text.Length != 0)
            {
                Test test = new Test()
                {
                    Id = Int32.Parse(txtTestID.Text),
                    Code = txtTestCode.Text,
                    Duration = dtpDuration.Value.TimeOfDay,
                    StartTime = dtpStartTime.Value.TimeOfDay,
                    TestDate = dtpStartDate.Value.Date,
                    IsReview = cbReview.Checked,
                    Subject = new Subject()
                    {
                        SubjectCode=txtSubject.Text.Split("-")[0].Trim(),
                        SubjectName=txtSubject.Text.Split("-")[1].Trim(),
                    }
                };
                TestDBContext testDBC = new TestDBContext();
                QuestionDBContext questionDBC = new QuestionDBContext();
                List<int> questionIds = new List<int>();
                foreach (DataGridViewRow row in dgvQuestion.Rows)
                {
                    questionIds.Add(
                    Int32.Parse(row.Cells["QuestionId"].Value.ToString())
                    );
                }

                if (testDBC.UpdateTest(test) > 0 && questionDBC.UpdateTestQuestion(test.Id, questionIds) > 0)
                {
                    MessageBox.Show("Update succesful");
                }
            }
            else
            {
                MessageBox.Show("Test Code must not be empty!", "Waring");
            }
        }
    }
}
