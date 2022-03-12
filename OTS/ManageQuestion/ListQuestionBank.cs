using OTS.DAO;
using OTS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS.ManageQuestion
{
    public partial class ListQuestionBank : Form
    {
        public ListQuestionBank()
        {
            InitializeComponent();
        }

        private void ListQuestionBank_Load(object sender, EventArgs e)
        {

            loadQues();
        }

        //private void dataQuestion_CellFormating(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (dataQuestion.Rows[e.RowIndex].DataBoundItem != null &&
        //dataQuestion.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
        //    {
        //        e.Value = BindProperty(dataQuestion.Rows[e.RowIndex].DataBoundItem,
        //            dataQuestion.Columns[e.ColumnIndex].DataPropertyName);
        //    }
        //}

        //private string BindProperty(object property, string propertyName)
        //{
        //    string retValue = "";

        //    if (propertyName.Contains("."))
        //    {
        //        PropertyInfo[] arrayProperties;
        //        string leftPropertyName;

        //        leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
        //        arrayProperties = property.GetType().GetProperties();

        //        foreach (PropertyInfo propertyInfo in arrayProperties)
        //        {
        //            if (propertyInfo.Name == leftPropertyName)
        //            {
        //                retValue = BindProperty(propertyInfo.GetValue(property, null),
        //                propertyName.Substring(propertyName.IndexOf(".") + 1));
        //                break;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Type propertyType;
        //        PropertyInfo propertyInfo;

        //        propertyType = property.GetType();
        //        propertyInfo = propertyType.GetProperty(propertyName);
        //        retValue = propertyInfo.GetValue(property, null).ToString();
        //    }

        //    return retValue;
        //}

        public void loadQues()
        {
            try
            {
                QuestionDBContext qDB = new QuestionDBContext();
                AnswerDBContext aDB = new AnswerDBContext();
                //BindingSource bs = new BindingSource();
                List<Question> questions = qDB.getQues();
                List<Answer> correctAns = aDB.getCorrectAnswer();
                var listQues = questions.Select(l => new
                {
                    Id = l.Id,
                    Content = l.Content,
                    Level = l.Level.Name,
                    SubCode = l.Subject.SubjectCode,
                    Type = l.Type.Name,
                    CorrectAnswer = correctAns.Where(c => c.Question.Id == l.Id).ToList().Select(c => c.Content).ToList()
                    .Aggregate((a, b) => a + ", " + b).ToString()
                }).ToList();
                dataQuestion.DataSource = listQues;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
