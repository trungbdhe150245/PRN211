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

namespace OTS.ReviewSubmission
{
    public partial class FrmReviewSubmission : Form
    {
        Submission currentSubmission = null;
        Mark mark;
        List<SubmissionQA> submissionQAs;
        List<Essay> essays = null;
        TestDBContext testDB = new TestDBContext();
        StudentDBContext studentDB = new StudentDBContext();
        SubmissionDBContext submissionDB = new SubmissionDBContext();
        MarkDBContext markDB = new MarkDBContext();
        SubmissionQADBContext submissionQADB = new SubmissionQADBContext();
        EssayDBContext essayDB = new EssayDBContext();
        public FrmReviewSubmission()
        {
            InitializeComponent();
        }

        public FrmReviewSubmission(int submissionID)
        {
            currentSubmission = submissionDB.GetSubmission(submissionID);
            if (currentSubmission != null)
            {
                mark = markDB.GetMark(currentSubmission.Test.Id, currentSubmission.Student.Id);
            }
            submissionQAs = submissionQADB.GetListSubmissionQAs(submissionID);

            InitializeComponent();
        }

        public FrmReviewSubmission(int testID, int studentID)
        {
            essays = essayDB.GetEssays(testID, studentID);
            mark = markDB.GetMark(testID, studentID);

            InitializeComponent();
        }

        private void FrmReviewSubmission_Load(object sender, EventArgs e)
        {
            if (currentSubmission != null)
            {
                lbStudentCode.Text = currentSubmission.Student.StudentCode;
                lbStudentName.Text = currentSubmission.Student.FullName;
                lbClass.Text = currentSubmission.Student.Class.ClassCode;
                lbTestCode.Text = currentSubmission.Test.Code;
                lbSubject.Text = currentSubmission.Test.Subject.ToString();
                lbSubmitTime.Text = currentSubmission.SubmitDate.ToString();
                lbTestDate.Text = currentSubmission.Test.TestDate.Date.ToShortDateString();
            }
            if (essays != null && essays.Count > 0)
            {
                lbStudentCode.Text = essays[0].Student.StudentCode;
                lbStudentName.Text = essays[0].Student.FullName;
                lbClass.Text = essays[0].Student.Class.ClassCode;
                lbTestCode.Text = essays[0].Test.Code;
                lbSubject.Text = essays[0].Test.Subject.ToString();
                lbSubmitTime.Text = essays[0].SubmitDate.ToString();
                lbTestDate.Text = essays[0].Test.TestDate.Date.ToShortDateString();
            }
            if (mark != null)
            {
                lbMark.Text = mark.Grade.ToString();
            }
            else
            {
                lbMark.Text = "";
            }
        }

    }
}
