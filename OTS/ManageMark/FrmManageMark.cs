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

namespace OTS.ManageMark
{
    public partial class FrmManageMark : Form
    {
        Test currentTest = null;
        MarkDBContext markDB = new MarkDBContext();
        ClassDBContext classDB = new ClassDBContext();
        SubmissionDBContext submissionDB = new SubmissionDBContext();
        public FrmManageMark()
        {
            InitializeComponent();
        }

        public FrmManageMark(Test test)
        {
            currentTest = test;
            InitializeComponent();
        }

        public void buildDGV()
        {
            dgvMark.AutoGenerateColumns = false;
            dgvMark.Columns.Clear();

            DataGridViewTextBoxColumn testCode = new DataGridViewTextBoxColumn();
            testCode.HeaderText = "TestCode";
            testCode.Name = "colTestCode";
            dgvMark.Columns.Add(testCode);

            DataGridViewTextBoxColumn studentCode = new DataGridViewTextBoxColumn();
            studentCode.HeaderText = "StudentCode";
            studentCode.Name = "colStudentCode";
            dgvMark.Columns.Add(studentCode);

            DataGridViewTextBoxColumn className = new DataGridViewTextBoxColumn();
            className.HeaderText = "Class";
            className.Name = "colClassName";
            dgvMark.Columns.Add(className);

            DataGridViewTextBoxColumn submitDate = new DataGridViewTextBoxColumn();
            submitDate.HeaderText = "SubmitDate";
            submitDate.Name = "colSubmitDate";
            dgvMark.Columns.Add(submitDate);

            DataGridViewTextBoxColumn mark = new DataGridViewTextBoxColumn();
            mark.HeaderText = "Mark";
            mark.DataPropertyName = "Grade";
            dgvMark.Columns.Add(mark);

            DataGridViewTextBoxColumn note = new DataGridViewTextBoxColumn();
            note.HeaderText = "Note";
            note.DataPropertyName = "Note";
            dgvMark.Columns.Add(note);
        }

        public void LoadClass()
        {
            try
            {
                var classList = classDB.GetClasses();
                cbClass.DataSource = classList;
                cbClass.DisplayMember = "ClassName";
                cbClass.ValueMember = "ClassCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadMark()
        {
            string testCode = null;
            string studentCode = null;
            string classCode = null;
            DateTime from = new DateTime();
            DateTime to = new DateTime();
            int pageIndex;
            int pageSize = 15;

            //get filter value when corresponding checkbox is checked
            if (chkTestCode.Checked)
            {
                testCode = txtTestCode.Text.Trim();
            }
            if (chkStudentCode.Checked)
            {
                studentCode = txtStudentCode.Text.Trim();
            }
            if (chkSubmitDate.Checked)
            {
                from = dtpFrom.Value.Date;
                to = dtpTo.Value.Date;
            }
            if (chkClass.Checked)
            {
                classCode = cbClass.SelectedValue.ToString();
            }

            int totalRecords = markDB.CountMarks(testCode, studentCode, classCode, from, to);
            int totalPages = totalRecords % pageSize == 0 ? totalRecords / pageSize : (totalRecords / pageSize) + 1;

            //set the page index
            if (txtPageIndex.Text.Trim().Equals(""))
            {
                pageIndex = 1;
            }
            else
            {
                try
                {
                    pageIndex = int.Parse(txtPageIndex.Text);
                    //if page index over the total of pages then redirect to end page
                    if (pageIndex > totalPages)
                    {
                        pageIndex = totalPages;
                    }
                }
                catch (Exception ex)
                {
                    //if user enter a non-numeric to page index then redirect to first page
                    pageIndex = 1;
                }
            }
            //enable the appropriate pagging button
            EnablePageButton(pageIndex, totalPages);

            //gets the data using corressponding filter data
            var marks = markDB.GetMarks(pageIndex, pageSize, testCode, studentCode, classCode, from, to);

            //set data to DGV
            dgvMark.DataSource = marks;
            for (int i = 0; i < marks.Count; i++)
            {
                Submission submission = submissionDB.GetSubmission(marks[i].Test.Id, marks[i].Student.Id);
                dgvMark.Rows[i].Cells["colTestCode"].Value = marks[i].Test.Code;
                dgvMark.Rows[i].Cells["colStudentCode"].Value = marks[i].Student.StudentCode;
                dgvMark.Rows[i].Cells["colClassName"].Value = marks[i].Student.Class.ClassName;
                dgvMark.Rows[i].Cells["colSubmitDate"].Value = submission.SubmitDate.Date;
            }
            //set data for paging text
            txtPageIndex.Text = pageIndex.ToString();
            lbTotalPage.Text = $"/{totalPages}";
        }

        public void EnablePageButton(int pageIndex, int totalPage)
        {
            if (pageIndex > 1)
            {
                btnFirstPage.Enabled = true;
                btnPrevPage.Enabled = true;
            }
            else
            {
                btnFirstPage.Enabled = false;
                btnPrevPage.Enabled = false;
            }

            if (pageIndex < totalPage)
            {
                btnLastPage.Enabled = true;
                btnNextPage.Enabled = true;
            }
            else
            {
                btnLastPage.Enabled = false;
                btnNextPage.Enabled = false;
            }
        }

        private void FrmManageMark_Load(object sender, EventArgs e)
        {
            try
            {
                buildDGV();
                LoadClass();
                LoadMark();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkTestCode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTestCode.Checked)
            {
                txtTestCode.Enabled = true;
            }
            else
            {
                txtTestCode.Enabled = false;
            }
        }

        private void chkStudentCode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStudentCode.Checked)
            {
                txtStudentCode.Enabled = true;
            }
            else
            {
                txtStudentCode.Enabled = false;
            }
        }

        private void chkClass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClass.Checked)
            {
                cbClass.Enabled = true;
            }
            else
            {
                cbClass.Enabled = false;
            }
        }

        private void chkSubmitDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSubmitDate.Checked)
            {
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
            }
            else
            {
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                txtPageIndex.Text = "1";
                LoadMark();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearCheckBox()
        {
            chkTestCode.Checked = false;
            chkStudentCode.Checked = false;
            chkClass.Checked = false;
            chkSubmitDate.Checked = false;
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            try
            {
                txtPageIndex.Text = "1";
                ClearCheckBox();
                LoadMark();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            txtPageIndex.Text = "1";
            try
            {
                LoadMark();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            int currentIndex = int.Parse(txtPageIndex.Text);
            txtPageIndex.Text = $"{--currentIndex}";
            try
            {
                LoadMark();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int currentIndex = int.Parse(txtPageIndex.Text);
            txtPageIndex.Text = $"{++currentIndex}";
            try
            {
                LoadMark();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            //Eg: lbTotalPage.Text = "/10" => substring from 1
            int totalPage = int.Parse(lbTotalPage.Text.Substring(1));
            txtPageIndex.Text = $"{totalPage}";
            try
            {
                LoadMark();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPageIndex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadMark();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {

        }

    }
}
