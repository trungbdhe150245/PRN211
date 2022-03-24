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

namespace OTS.ManageSubmission
{
    public partial class FrmManageSubmission : Form
    {
        public FrmManageSubmission()
        {
            InitializeComponent();
        }
        SubmissionDBContext submissionDB = new();
        ClassDBContext classDB = new();
        SubjectDBContext subjectDB = new();
        MarkDBContext markDB = new();

        private void LoadClass()
        {
            List<Class> classes = classDB.GetClasses();
            cbClass.DataSource = classes;
            cbClass.ValueMember = "ClassCode";
            cbClass.DisplayMember = "ClassCode";
        }

        private void ReloadDgv()
        {
            dgvSubmission.Rows.Clear();
        }

        private void LoadDgvSubmission()
        {
            string testCode = "";
            if (txtTestCode.Text != null)
            {
                testCode = txtTestCode.Text;
            }
            string classCode = "";
            if (cbClass.Text != null)
            {
                classCode = cbClass.Text;
            }
            string stuCode = "";
            if (txtStudentCode.Text != null)
            {
                stuCode = txtStudentCode.Text;
            }
            List<Submission> submissions = submissionDB.GetManageSubmissions(testCode, classCode, stuCode);
            foreach (Submission submission in submissions)
            {
                Subject subject = subjectDB.GetSubjectBySubmission(submission.Id);
                Mark mark = markDB.GetMarkSubmission(submission.Id, submission.Test.Code, submission.Student.StudentCode);
                dgvSubmission.Rows.Add(submission.Id,
                    submission.Test.Code,
                    submission.Student.Class.ClassCode,
                    subject.SubjectCode,
                    submission.Student.StudentCode,
                    submission.Student.FullName,
                    submission.SubmitDate,
                    mark.Grade,
                    "Review");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            ReloadDgv();
            string testCode = "";
            if (txtTestCode.Text != null)
            {
                testCode = txtTestCode.Text;
            }
            string classCode = "";
            if (cbClass.Text != null)
            {
                classCode = cbClass.Text;
            }
            string stuCode = "";
            if (txtStudentCode.Text != null)
            {
                stuCode = txtStudentCode.Text;
            }
            List<Submission> submissions = submissionDB.GetManageSubmissions(testCode, classCode, stuCode);
            foreach (Submission submission in submissions)
            {
                Subject subject = subjectDB.GetSubjectBySubmission(submission.Id);
                Mark mark = markDB.GetMarkSubmission(submission.Id, submission.Test.Code, submission.Student.StudentCode);
                dgvSubmission.Rows.Add(submission.Id,
                    submission.Test.Code,
                    submission.Student.Class.ClassCode,
                    subject.SubjectCode,
                    submission.Student.StudentCode,
                    submission.Student.FullName,
                    submission.SubmitDate,
                    mark.Grade,
                    "Review");
            }
        }

        private void FrmManageSubmission_Load(object sender, EventArgs e)
        {
            try
            {
                LoadClass();
                LoadDgvSubmission();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
