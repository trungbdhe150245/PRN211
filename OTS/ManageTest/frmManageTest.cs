using OTS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS.ManageTest
{
    public partial class frmManageTest : Form
    {
        public frmManageTest()
        {
            InitializeComponent();
        }

        TestDBContext testDB = new TestDBContext();

        public void buildDGV()
        {
            dgvTest.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn testCode = new DataGridViewTextBoxColumn();
            testCode.DataPropertyName = "Code";
            testCode.HeaderText = "Code";
            dgvTest.Columns.Add(testCode);

            DataGridViewTextBoxColumn subject = new DataGridViewTextBoxColumn();
            subject.DataPropertyName = "Subject";
            subject.HeaderText = "Subject";
            dgvTest.Columns.Add(subject);

            DataGridViewTextBoxColumn testDate = new DataGridViewTextBoxColumn();
            testDate.DataPropertyName = "TestDate";
            testDate.HeaderText = "TestDate";
            testDate.Width = 70;
            dgvTest.Columns.Add(testDate);

            DataGridViewTextBoxColumn createDate = new DataGridViewTextBoxColumn();
            createDate.DataPropertyName = "CreateDate";
            createDate.HeaderText = "CreateDate";
            createDate.Width = 70;
            dgvTest.Columns.Add(createDate);

            DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn();
            status.HeaderText = "Status";
            dgvTest.Columns.Add(status);

            DataGridViewButtonColumn buttonCol1 = new DataGridViewButtonColumn();
            buttonCol1.Text = "Start";
            buttonCol1.Width = 70;
            dgvTest.Columns.Add(buttonCol1);

            DataGridViewButtonColumn buttonCol2 = new DataGridViewButtonColumn();
            buttonCol2.Text = "End";
            buttonCol2.Width = 70;
            dgvTest.Columns.Add(buttonCol2);

            DataGridViewButtonColumn buttonCol3 = new DataGridViewButtonColumn();
            buttonCol3.Text = "View detail";
            dgvTest.Columns.Add(buttonCol3);

        }

        public void LoadTest()
        {
            var tests = testDB.GetTests();
            dgvTest.DataSource = tests;
            for (int i = 0; i < tests.Count; i++)
            {
                if(tests[i].TestDate == DateTime.Now.Date 
                    && tests[i].StartTime <= DateTime.Now.TimeOfDay
                    && tests[i].EndTime > DateTime.Now.TimeOfDay)
                {
                    dgvTest.Rows[i].Cells[4].Value = "Started";
                }
                else if (tests[i].TestDate > DateTime.Now.Date
                    ||(tests[i].TestDate == DateTime.Now.Date
                    && tests[i].EndTime < DateTime.Now.TimeOfDay))
                {
                    dgvTest.Rows[i].Cells[4].Value = "Ended";
                }
                else
                {
                    dgvTest.Rows[i].Cells[4].Value = "Not started";
                }
                dgvTest.Rows[i].Cells[5].Value = "Start";
                dgvTest.Rows[i].Cells[6].Value = "End";
                dgvTest.Rows[i].Cells[7].Value = "View detail";
            }
        }

        private void frmManageTest_Load(object sender, EventArgs e)
        {
            try
            {
                buildDGV();
                LoadTest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
