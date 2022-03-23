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
        Submission currentSubmission;
        Mark mark;
        List<SubmissionQA> submissionQAs;
        List<Essay> essays;
        TestDBContext testDB = new TestDBContext();
        StudentDBContext studentDB = new StudentDBContext();
        SubmissionDBContext submissionDB = new SubmissionDBContext();
        MarkDBContext markDB = new MarkDBContext();
        SubmissionQADBContext submissionQADB = new SubmissionQADBContext();
        public FrmReviewSubmission()
        {
            InitializeComponent();
        }

        public FrmReviewSubmission(int submissionID)
        {
            currentSubmission = submissionDB.GetSubmission(submissionID);
            mark = markDB.GetMark(currentSubmission.Test.Id, currentSubmission.Student.Id);
            submissionQAs = submissionQADB.GetListSubmissionQAs(submissionID);
            
            InitializeComponent();
        }
    }
}
