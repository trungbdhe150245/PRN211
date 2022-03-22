﻿using OTS.DAO;
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

namespace OTS.ManageTest
{
    public partial class frmManageTest : Form
    {
        public frmManageTest()
        {
            InitializeComponent();
        }

        TestDBContext testDB = new TestDBContext();
        SubjectDBContext subjectDB = new SubjectDBContext();

        public void buildDGV()
        {
            dgvTest.AutoGenerateColumns = false;
            dgvTest.Columns.Clear();

            DataGridViewTextBoxColumn testId = new DataGridViewTextBoxColumn();
            testId.DataPropertyName = "Id";
            testId.HeaderText = "Id";
            testId.Width = 30;
            dgvTest.Columns.Add(testId);

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

        public void LoadSubject()
        {
            try
            {
                var subjects = subjectDB.GetSubjects();
                cbSubject.DataSource = subjects;
                cbSubject.DisplayMember = "SubjectCode";
                cbSubject.ValueMember = "SubjectCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EnablePageButton(int pageIndex, int pageSize)
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

            if (pageIndex < pageSize)
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

        public void LoadTest()
        {
            string subjectCode = null;
            DateTime createFrom = new DateTime();
            DateTime createTo = new DateTime();
            DateTime testFrom = new DateTime();
            DateTime testTo = new DateTime();
            string status = null;
            int pageIndex;
            int pageSize = 10;

            int totalRecords = testDB.CountTests(subjectCode, createFrom, createTo,
                    testFrom, testTo, status);
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
                    if(pageIndex > totalPages)
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
            EnablePageButton(pageIndex, pageSize);

            //get filter value when corresponding checkbox is checked
            if (chkSubject.Checked)
            {
                subjectCode = cbSubject.SelectedValue.ToString();
            }
            if (chkCreate.Checked)
            {
                createFrom = dtpCreateFrom.Value;
                createTo= dtpCreateTo.Value;
            }
            if (chkTest.Checked)
            {
                testFrom = dtpTestFrom.Value;
                testTo = dtpTestTo.Value;
            }
            if (chkStatus.Checked)
            {
                status = cbStatus.SelectedItem.ToString();
            }

            //gets the data using corressponding filter data
            var tests = testDB.GetTests(pageIndex, pageSize, subjectCode
                , createFrom, createTo, testFrom, testTo, status);

            //set data to DGV
            dgvTest.DataSource = tests;
            for (int i = 0; i < tests.Count; i++)
            {
                //Set status for status cell
                if(tests[i].TestDate == DateTime.Now.Date 
                    && tests[i].StartTime <= DateTime.Now.TimeOfDay
                    && tests[i].EndTime > DateTime.Now.TimeOfDay)
                {
                    dgvTest.Rows[i].Cells[5].Value = "Started";
                }
                else if (tests[i].TestDate < DateTime.Now.Date
                    ||(tests[i].TestDate == DateTime.Now.Date
                    && tests[i].EndTime < DateTime.Now.TimeOfDay))
                {
                    dgvTest.Rows[i].Cells[5].Value = "Ended";
                }
                else
                {
                    dgvTest.Rows[i].Cells[5].Value = "Not started";
                }
                //Set text for button cell
                dgvTest.Rows[i].Cells[6].Value = "Start";                
                dgvTest.Rows[i].Cells[7].Value = "End";
                dgvTest.Rows[i].Cells[8].Value = "View detail";
            }
            //set data for paging text
            txtPageIndex.Text = pageIndex.ToString();
            lbTotalPage.Text = $"/{totalPages}";
        }

        private void frmManageTest_Load(object sender, EventArgs e)
        {
            try
            {
                buildDGV();
                LoadSubject();
                LoadTest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearCheckBox()
        {
            chkSubject.Checked = false;
            chkCreate.Checked = false;
            chkTest.Checked = false;
            chkStatus.Checked = false;
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ClearCheckBox();
                LoadTest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkSubject_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSubject.Checked)
            {
                cbSubject.Enabled = true;
            }
            else
            {
                cbSubject.Enabled = false;
            }
        }

        private void chkCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCreate.Checked)
            {
                dtpCreateFrom.Enabled = true;
                dtpCreateTo.Enabled = true;
            }
            else
            {
                dtpCreateFrom.Enabled = false;
                dtpCreateTo.Enabled = false;
            }
        }

        private void chkTest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTest.Checked)
            {
                dtpTestFrom.Enabled = true;
                dtpTestTo.Enabled = true;
            }
            else
            {
                dtpTestFrom.Enabled = false;
                dtpTestTo.Enabled = false;
            }
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStatus.Checked)
            {
                cbStatus.Enabled = true;
                cbStatus.SelectedIndex = 0;
            }
            else
            {
                cbStatus.Enabled = false;
                cbStatus.SelectedIndex = 0;
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            txtPageIndex.Text = "1";
            try
            {
                LoadTest();
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
                LoadTest();
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
                LoadTest();
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
                LoadTest();
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
                LoadTest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //col0: test id
            //col6: start button
            //col7: end button
            //col8: detail button
            int testID = int.Parse(dgvTest.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (e.ColumnIndex == 6)
            {
                btnStart_Click(testID);
            } 
            else if (e.ColumnIndex == 7)
            {
                btnEnd_Click(testID);
            }
            else if (e.ColumnIndex == 8)
            {
                btnDetail_Click(testID);
            }
        }

        private void btnDetail_Click(int testID)
        {
            throw new NotImplementedException();
        }

        private void btnEnd_Click(int testID)
        {
            throw new NotImplementedException();
        }

        private void btnStart_Click(int testID)
        {
            Test test = testDB.GetTest(testID);
            frmStartTest frmStart = new frmStartTest(test, this);
            frmStart.Show();
        }

        private void frmManageTest_Activated(object sender, EventArgs e)
        {
            try
            {
                LoadTest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
