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

namespace OTS.StudenDashBoard
{
    public partial class formReviewDetail : Form
    {
        private Student targetStu;
        private Dictionary<Submission, Mark> targetSub;
        private string testCode;
        public formReviewDetail(Student s, Dictionary<Submission, Mark> sub,string testId)
        {
            testCode = testId;
            targetStu = s;
            targetSub = sub;
            InitializeComponent();
        }

        private void formReviewDetail_Load(object sender, EventArgs e)
        {
            QuestionDBContext qDB = new QuestionDBContext();
            AnswerDBContext aDB = new AnswerDBContext();
            TestDBContext tDB = new TestDBContext();
            SubmissionDBContext sDB = new SubmissionDBContext();
            Test t = new Test();
            foreach (var item in targetSub.Keys)
            {
                if(testCode.Equals(item.Test.Code))
                {
                    t = item.Test;
                }
            }
            List<Answer> answers = aDB.getQuesByTest(t.Id);
            List<SubmissionQA> subQAs = sDB.getSubByTest(t.Id, targetStu.Id);
            Dictionary<SubmissionQA,Answer > list = new Dictionary<SubmissionQA, Answer>();

            foreach (var item in subQAs)
            {
                int i = 0;
                //list.;
            }

        }
    }
}
