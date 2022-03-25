using Microsoft.Data.SqlClient;
using OTS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS.DAO
{
    public class SubmissionDBContext : DBContext 
    {
        public Dictionary<Submission,Mark> viewListResult(int id)
        {
            string view = @$"SELECT Submission.Id,Submission.SubmitDate,Submission.Duration,Test.Code,Submission.SubmitDate,Mark.Mark,
Test.Code,Test.CreateDate,Test.Duration,Test.EndTime,Test.Id,Test.Review,Test.StartTime,Test.SubjectCode,Test.TestDate,Subject.SubjectName,
Student.Id,Student.ClassCode,Student.Dob,Student.FullName,Student.Password,Student.StudentCode,Class.ClassName,Mark.Note
FROM Submission JOIN Student ON Submission.StudentId = Student.Id JOIN Test
ON Test.Id = Submission.TestId JOIN Mark on (Mark.StudentId = Student.Id and Mark.TestId = Test.Id) 
JOIN Subject ON Subject.SubjectCode = Test.SubjectCode JOIN Class ON Class.ClassCode = Student.ClassCode  WHERE Student.Id = {id}";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(view, connection);
                Dictionary<Submission, Mark> listView = new Dictionary<Submission, Mark>();
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ClassDBContext cDb = new ClassDBContext();
                        Submission s = new Submission();
                        //s.Duration = reader.GetTimeSpan(2);
                        s.SubmitDate = reader.GetDateTime(4);
                        s.Test = new Test()
                        {
                            Code = reader.GetString(6),
                            CreateDate = reader.GetDateTime(7),
                            Duration = reader.GetTimeSpan(8),
                            Id = reader.GetInt32(10),
                            IsReview = reader.GetBoolean(11),
                            StartTime = reader.GetTimeSpan(12),
                            Subject = new Subject()
                            {
                                SubjectCode = reader.GetString(13),
                                SubjectName = reader.GetString(15)
                            },
                            
                            TestDate = reader.GetDateTime(14)

                        };
                        Mark m = new Mark()
                        {
                            Grade = reader.GetFloat(5),
                            Student = new Student
                            {
                                Id = reader.GetInt32(16),
                                Class = new Class()
                                {
                                    ClassCode = reader.GetString(17),
                                    ClassName = reader.GetString(22)
                                },
                                DateOfBirth = reader.GetDateTime(18),
                                FullName = reader.GetString(19),
                                Password = reader.GetString(20),
                                StudentCode = reader.GetString(21)

                            },
                            Test = s.Test,
                        };
                        listView.Add(s, m);
                    }
                }
                return listView;
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

        public List<SubmissionQA> getSubByTest(int testId, int stuID)
        {
            string sql_get = "";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_get, connection);
                List<SubmissionQA> listView = new List<SubmissionQA>();
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ClassDBContext cDb = new ClassDBContext();
                        Submission s = new Submission()
                        {
                            Student = new Student
                            {
                                Id = stuID
                            },
                            Test = new Test
                            {
                                Id = testId
                            }
                        };
                        //s.Duration = reader.GetTimeSpan(2);

                        Question q = new Question()
                        {
                            Id = reader.GetInt32(0),
                            Content = reader.GetString(1)
                        };
                        Answer a = new Answer()
                        {
                            Id = reader.GetInt32(2),
                            Content = reader.GetString(3),
                            IsCorrect = reader.GetBoolean(4)
                        };
                        SubmissionQA sQA = new SubmissionQA()
                        {
                            Answer = a,
                            Question = q,
                            Submission = s,
                        };
                    }
                }
                return listView;
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
    }
}
