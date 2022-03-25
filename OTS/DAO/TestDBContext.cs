using Microsoft.Data.SqlClient;
using OTS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS.DAO
{
    public class TestDBContext : DBContext
    {
        //public Test GetTest(int testId)
        //{
        //    string sql_select_test = "";
        //    try
        //    {
        //        connection = new SqlConnection(GetConnectionString());
        //        command = new SqlCommand(sql_select_test, connection);

        //        connection.Open();
        //        reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            return new Test()
        //            {
        //                Id = testId,
        //                Code = reader.GetString(""),
        //                CreateDate = reader.GetDateTime(""),
        //                TestDate = reader.GetDateTime(""),
        //                //StartTime = reader.GetTimeSpan(""),
        //                //Duration = reader.GetTimeSpan(""),
        //                Subject = new Subject() { 
        //                    SubjectCode = reader.GetString(""),
        //                    SubjectName = reader.GetString(""),
        //                },
        //                IsReview = reader.GetBoolean("")
        //            };
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return null;
        //}

        public Test GetTest(string testcode)
        {



            try
            {
                string sql_select_test = "Select t.Id as 'TestId', t.Code as 'TestCode', s.SubjectCode as 'Subject', " +
                                        "t.StartTime, t.TestDate, t.Duration, t.CreateDate, t.EndTime, q.Id as 'QuestionId', q.Content as 'QuestionContent', " +
                                        "tp.Name as 'Type', tp.Id as 'TypeId' from Test t " +
                                        "inner join Question_Test qt on t.Id = qt.TestId " +
                                        "inner join Question q on qt.QuestionId = q.Id " +
                                        "inner join Type tp on tp.Id = q.Type " +
                                        "inner join Subject s on t.SubjectCode = s.SubjectCode where t.Code = @code";
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_test, connection);
                command.Parameters.AddWithValue("@code", testcode);

                connection.Open();
                reader = command.ExecuteReader();


                Test t = null;
                Subject s = null;


                while (reader.Read())
                {

                    if (t == null)
                    {
                        t = new Test();
                        //t.Id = testId;
                        t.Code = testcode;
                        t.Duration = reader.GetTimeSpan(5);
                        t.StartTime = reader.GetTimeSpan(3);
                        t.EndTime = reader.GetTimeSpan(7);
                    }

                    if (s == null)
                    {
                        s = new Subject();
                        s.SubjectCode = reader.GetString("Subject");
                    }

                    Question q = new Question();
                    q.Id = reader.GetInt32("QuestionId");
                    q.Content = reader.GetString("QuestionContent");
                    q.Type = new Models.Type() { Id = reader.GetInt16("TypeId"), Name = reader.GetString("Type") };

                    QuestionTest qt = new QuestionTest();
                    qt.Question = q;
                    qt.Test = t;

                    t.Subject = s;
                    t.QuestionTests.Add(qt);

                }

                foreach (var qt in t.QuestionTests)
                {
                    qt.Question.Answers = GetAnswers(qt.Question);
                }
                //connection.Close();


                //string sql_select_answer = "select q.Id,a.Content from Question q inner join Answer a on q.Id = a.QuestionId where q.SubjectCode = @subjectcode";
                //connection = new SqlConnection(GetConnectionString());
                //command = new SqlCommand(sql_select_answer, connection);
                //command.Parameters.AddWithValue("@subjectcode", t.Subject.SubjectCode);
                //connection.Open();
                //reader = command.ExecuteReader();

                //foreach (var qt in t.QuestionTests)
                //{
                //    while(reader.Read())
                //    {
                //        Answer a = new Answer();
                //        a.Content = reader.GetString("Content");
                //        string content = reader.GetString("Content");
                //        int id = reader.GetInt32("Id");
                //        if (qt.Question.Id == reader.GetInt32("Id"))
                //        {

                //            qt.Question.Answers.Add(a);
                //        }
                //    }
                //}
                //connection.Close();
                return t;
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public List<Answer> GetAnswers(Question question)
        {
            List<Answer> answers = new List<Answer>();
            string sql_select_answer = "select a.Content from Question q inner join Answer a on q.Id = a.QuestionId where q.Id = @id"; ;
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_answer, connection);
                command.Parameters.AddWithValue("@id", question.Id);
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    answers.Add(new Answer() { Content = reader.GetString("Content") });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return answers;
        }
    }
}
