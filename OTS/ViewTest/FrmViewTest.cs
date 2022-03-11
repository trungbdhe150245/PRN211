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
                        questionTest.Question.Level.Name,
                        questionTest.Question.Type.Name,
                         "Change"
                        );
                }
                //dgvQuestion.DataSource = questionTestDisplays;
            } catch (Exception ex)
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
                if(test != null)
                {
                    txtTestID.Text = test.Id.ToString();
                    txtTestCode.Text = test.Code;
                    txtSubject.Text = test.Subject.SubjectCode
                        + " - " + test.Subject.SubjectName;
                    dtpCreateDate.Value = test.CreateDate;
                    dtpStartDate.Value = test.TestDate;
                    DateTime dt = new DateTime(2022,12,31);
                    dtpStartTime.Value = dt.Add(test.StartTime);
                    dtpDuration.Value = dt.Add(test.Duration);

                    LoadQuestionsList();
                }
            }catch(Exception ex) {
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
    }
}
