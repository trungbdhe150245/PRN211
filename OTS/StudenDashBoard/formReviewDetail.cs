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
        public formReviewDetail(Student s, Dictionary<Submission, Mark> sub)
        {
            targetStu = s;
            targetSub = sub;
            InitializeComponent();
        }

        private void formReviewDetail_Load(object sender, EventArgs e)
        {
            QuestionDBContext qDB = new QuestionDBContext();
            AnswerDBContext aDB = new AnswerDBContext();
            TestDBContext tDB = new TestDBContext();
            List<Answer> answers = aDB.getQuesByTest(tDB.GetTestByStudentId(targetStu.Id).Id);


        }
    }
}
