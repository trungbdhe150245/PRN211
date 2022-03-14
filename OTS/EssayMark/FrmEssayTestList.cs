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

namespace OTS.EssayMark
{
    public partial class FrmEssayTestList : Form
    {
        private int testId, studentId;
        public FrmEssayTestList(int testId, int studentId)
        {
            this.testId = testId;
            this.studentId = studentId;
            InitializeComponent();
        }

        public void LoadEssaySubmission()
        {
            try
            {
                TestDBContext testDBC = new TestDBContext();
                Test test = testDBC.GetTest(testId);
                Mark mark = new MarkDBContext().GetMark(testId, studentId);
                List<Essay> essays = new EssayDBContext().GetEssays(testId, studentId);
                txtTestId.Text = test.Id.ToString();
                txtSubject.Text = test.Subject.ToString();
                txtNote.Text = (mark == null)? "" : mark.Note;
                nudMark.Value = (mark == null)?  0 : (decimal)mark.Grade;
                foreach (Essay essay in essays)
                {
                    dgvSolution.Rows.Add(essay.Id, essay.Question.Content, "Detail");
                }

            }catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                Mark mark = new Mark()
                {
                    Note = txtNote.Text,
                    Grade = (float) nudMark.Value,
                    Student = new Student()
                    {
                        Id = studentId,
                    },
                    Test = new Test()
                    {
                        Id=testId,
                    },
                };

                MarkDBContext markDBC = new MarkDBContext();
                markDBC.DeleteMark(testId, studentId);
                if (markDBC.SetMark(mark) > 0)
                {
                    MessageBox.Show("Save Successful");
                };
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
            this.Close();
        }

        private void dgvSolution_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if(e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                int essayId = Int32.Parse(dgv.Rows[e.RowIndex].Cells["EssayId"].Value.ToString());
                FrmEssayDetail frmEssayDetail = new FrmEssayDetail(essayId);
                frmEssayDetail.Show();
            }
        }

        private void FrmEssayTestList_Load(object sender, EventArgs e)
        {
            LoadEssaySubmission();
        }
    }
}
