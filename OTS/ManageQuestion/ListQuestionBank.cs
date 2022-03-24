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
        private string searchKey = "";
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
                TypeDBContext tDB = new TypeDBContext();
                List<Question> questions = qDB.getQues(searchKey,"content");
                List<Answer> answers = aDB.getAnswer();
                var types = tDB.GetTypes();
                checkType.DataSource = types;
                checkType.DisplayMember = "Name";

                foreach (var item in questions)
                {
                    item.Answers = answers.Where(a => a.Question.Id == item.Id).ToList();
                }
                if (checkType.SelectedIndex == 0)
                {
                    var listQues = questions.Where(q => q.Type.Id == 1).Select(l => new
                    {
                        Id = l.Id,
                        Content = l.Content,
                        Level = l.Level.Name,
                        SubCode = l.Subject.SubjectCode,
                        Type = l.Type.Name,
                        CorrectAns = l.Answers.FirstOrDefault(c => c.IsCorrect).Content.ToString()
                    }).ToList();
                    dataQuestion.DataSource = listQues;
                }
                else
                {
                    var listQues = questions.Where(q => q.Type.Id == 2).Select(l => new
                    {
                        Id = l.Id,
                        Content = l.Content,
                        Level = l.Level.Name,
                        SubCode = l.Subject.SubjectCode,
                        Type = l.Type.Name,
                    }).ToList();
                    dataQuestion.DataSource = listQues;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnswerDBContext aDB = new AnswerDBContext();
            QuestionDBContext qDB = new QuestionDBContext();
            TypeDBContext tDB = new TypeDBContext();
            List<Question> questions = qDB.getQues(searchKey,"content");
            List<Answer> answers = aDB.getAnswer();
            foreach (var item in questions)
            {
                item.Answers = answers.Where(a => a.Question.Id == item.Id).ToList();
            }
            if (checkType.SelectedIndex == 0)
            {
                checkType.SelectedItem = tDB.GetTypes().FirstOrDefault(c => c.Id == 1);
                var listQues = questions.Where(q => q.Type.Id == 1).Select(l => new
                {
                    Id = l.Id,
                    Content = l.Content,
                    Level = l.Level.Name,
                    SubCode = l.Subject.SubjectCode,
                    Type = l.Type.Name,
                    CorrectAns = l.Answers.FirstOrDefault(c => c.IsCorrect).Content.ToString()
                }).ToList();
                dataQuestion.DataSource = listQues;
                return;
            }
            else
            {
                checkType.SelectedItem = tDB.GetTypes().FirstOrDefault(c => c.Id == 2);
                var listQues = questions.Where(q => q.Type.Id == 2).Select(l => new
                {
                    Id = l.Id,
                    Content = l.Content,
                    Level = l.Level.Name,
                    SubCode = l.Subject.SubjectCode,
                    Type = l.Type.Name,
                }).ToList();
                dataQuestion.DataSource = listQues;
            }
        }

        private void addQues_Click(object sender, EventArgs e)
        {
            AddQuestion aq = new AddQuestion(this);
            aq.Show();
        }

        private void searchQues_Click(object sender, EventArgs e)
        {
            searchKey = textBox1.Text;

            loadQues();
        }
    }
}
