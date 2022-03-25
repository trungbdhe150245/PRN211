﻿using Microsoft.Data.SqlClient;
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
        public Test GetTestByCode(string testCode)
        {

            string sql_select_test = @"SELECT [Id]
                                      ,[Code]
                                      ,[StartTime]
                                      ,[TestDate]
                                      ,[Duration]
                                      ,[EndTime]
                                      ,Test.[SubjectCode]
	                                  ,Subject.SubjectName
                                      ,[CreateDate]
                                      ,[Review]
                                  FROM [Test] INNER JOIN Subject
			                                ON Subject.SubjectCode=Test.SubjectCode
                                  WHERE Test.Code = @testCode";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_test, connection);
                command.Parameters.AddWithValue("@testCode", testCode);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Test()
                    {
                        Id = reader.GetInt32("Id"),
                        Code = reader.GetString("Code"),
                        CreateDate = reader.GetDateTime("CreateDate"),
                        TestDate = reader.GetDateTime("TestDate"),
                        StartTime = (TimeSpan)reader["StartTime"],
                        Duration = (TimeSpan)reader["Duration"],
                        Subject = new Subject()
                        {
                            SubjectCode = reader.GetString("SubjectCode"),
                            SubjectName = reader.GetString("SubjectName"),
                        },
                        EndTime = (TimeSpan)reader["EndTime"],
                        IsReview = reader.GetBoolean("Review")
                    };
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
            return null;
        }
        public int UpdateClassesTest(int testId, List<string> classCodes)
        {
            int rowAffects = 0;
            try
            {
                DeleteTestClass(testId);
                string sql_insert_class = @"INSERT INTO [Test_Class]
                                           ([TestId]
                                           ,[ClassCode])
                                     VALUES
                                           (@testId
                                           ,@classCode)";
                connection = new SqlConnection(GetConnectionString());
                connection.Open();
                foreach (string classCode in classCodes)
                {
                    command = new SqlCommand(sql_insert_class, connection);
                    command.Parameters.AddWithValue("@testId", testId);
                    command.Parameters.AddWithValue("classCode", classCode);
                    rowAffects += command.ExecuteNonQuery();
                }

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { connection.Close(); }

            return rowAffects;
        }
        public int DeleteTest(int testId)
        {

            int rowAffects = 0;
            string sql_delete = @"DELETE FROM [Test]
                        WHERE Id=@testId";
            try
            {
                QuestionDBContext questionDBC = new QuestionDBContext();
                questionDBC.DeleteQuestionTest(testId);
                DeleteTestClass(testId);

                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_delete, connection);
                command.Parameters.AddWithValue("@testId", testId);
                connection.Open();
                rowAffects = command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { connection.Close(); }

            return rowAffects;
        }
        public int DeleteTestClass(int testId)
        {
            int rowAffects = 0;
            string sql_delete = @"DELETE FROM [Test_Class]
                        WHERE TestId=@testId";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_delete, connection);
                command.Parameters.AddWithValue("@testId", testId);
                connection.Open();
                rowAffects = command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { connection.Close(); }

            return rowAffects;
        }
        public int UpdateTest(Test test)
        {
            int rowAffects = 0;
            string sql_update_test = @"UPDATE [dbo].[Test]
                               SET [Code] = @Code
                                  ,[StartTime] = @startTime
                                  ,[TestDate] = @testDate
                                  ,[Duration] = @duration
                                  ,[EndTime] = @endtime
                                  ,[Review] = @review
                             WHERE Test.Id=@testId";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_update_test, connection);
                command.Parameters.AddWithValue("@testId", test.Id);
                command.Parameters.AddWithValue("@Code", test.Code);
                command.Parameters.AddWithValue("@startTime", test.StartTime);
                command.Parameters.AddWithValue("@testDate", test.TestDate);
                command.Parameters.AddWithValue("@duration", test.Duration);
                command.Parameters.AddWithValue("@review", test.IsReview);
                command.Parameters.AddWithValue("@endtime", test.EndTime);
                connection.Open();
                rowAffects = command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { connection.Close(); }

            return rowAffects;
        }
        public Test GetTest(int testId)
        {
            string sql_select_test = @"SELECT [Id]
                                      ,[Code]
                                      ,[StartTime]
                                      ,[TestDate]
                                      ,[Duration]
                                      ,[EndTime]
                                      ,Test.[SubjectCode]
	                                  ,Subject.SubjectName
                                      ,[CreateDate]
                                      ,[Review]
                                  FROM [Test] INNER JOIN Subject
			                                ON Subject.SubjectCode=Test.SubjectCode
                                  WHERE Test.Id = @testId";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_test, connection);
                command.Parameters.AddWithValue("@testId", testId);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Test()
                    {
                        Id = testId,
                        Code = reader.GetString("Code"),
                        CreateDate = reader.GetDateTime("CreateDate"),
                        TestDate = reader.GetDateTime("TestDate"),
                        StartTime = (TimeSpan)reader["StartTime"],
                        EndTime = (TimeSpan)reader["EndTime"],
                        Duration = (TimeSpan)reader["Duration"],
                        Subject = new Subject()
                        {
                            SubjectCode = reader.GetString("SubjectCode"),
                            SubjectName = reader.GetString("SubjectName"),
                        },
                        IsReview = reader.GetBoolean("Review")
                    };
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
            return null;
        }

        public List<Test> GetTests(int pageIndex, int pageSize, string subjectCode
            , DateTime createFrom, DateTime createTo, DateTime testFrom, DateTime testTo, string status)
        {
            List<Test> tests = new List<Test>();

            string table_rowNum = @"SELECT ROW_NUMBER() OVER (ORDER BY [ID] ASC) as rownum, * 
                                    FROM [Test]
                                    WHERE 1=1 ";
            if (subjectCode != null && !subjectCode.Equals(""))
            {
                table_rowNum += " AND [Test].[SubjectCode] = @subjectCode ";
            }
            if (createFrom != new DateTime() && createTo != new DateTime())
            {
                table_rowNum += " AND CAST([Test].[CreateDate] AS date) between @createFrom and @createTo ";
            }
            if (testFrom != new DateTime() && testTo != new DateTime())
            {
                table_rowNum += " AND [Test].[TestDate] between @testFrom and @testTo ";
            }

            if (status != null && status.Equals("Started"))
            {
                table_rowNum += @" AND (CAST(TestDate AS datetime) + CAST(StartTime AS datetime)) < GETDATE()
                                    AND (CAST(TestDate AS datetime) + CAST(EndTime AS datetime)) > GETDATE() ";
            }
            else if (status != null && status.Equals("Ended"))
            {
                table_rowNum += @" AND (CAST(TestDate AS datetime) + CAST(EndTime AS datetime)) <= GETDATE() ";
            }
            else if (status != null && status.Equals("Not Started"))
            {
                table_rowNum += @" AND (CAST(TestDate AS datetime) + CAST(StartTime AS datetime)) >= GETDATE() ";
            }

            string sql_select_test = @$"SELECT [Id]
                                      ,[Code]
                                      ,[StartTime]
                                      ,[EndTime]
                                      ,[TestDate]
                                      ,[Duration]
                                      ,p.[SubjectCode]
	                                  ,Subject.SubjectName
                                      ,[CreateDate]
                                      ,[Review]
                                  FROM ({table_rowNum}) as p INNER JOIN Subject
			                                ON Subject.SubjectCode=p.SubjectCode
                                  WHERE p.rownum >= ({pageIndex} - 1)*{pageSize} + 1
                                        AND p.rownum <= {pageIndex}*{pageSize} ";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_test, connection);
                if (subjectCode != null && !subjectCode.Equals(""))
                {
                    command.Parameters.AddWithValue("@subjectCode", subjectCode);
                }
                if (createFrom != new DateTime() && createTo != new DateTime())
                {
                    command.Parameters.AddWithValue("@createFrom", createFrom);
                    command.Parameters.AddWithValue("@createTo", createTo);
                }
                if (testFrom != new DateTime() && testTo != new DateTime())
                {
                    command.Parameters.AddWithValue("@testFrom", testFrom);
                    command.Parameters.AddWithValue("@testTo", testTo);
                }

                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tests.Add(new Test()
                    {
                        Id = reader.GetInt32("ID"),
                        Code = reader.GetString("Code"),
                        CreateDate = reader.GetDateTime("CreateDate"),
                        TestDate = reader.GetDateTime("TestDate"),
                        EndTime = (TimeSpan)reader["EndTime"],
                        StartTime = (TimeSpan)reader["StartTime"],
                        Duration = (TimeSpan)reader["Duration"],
                        Subject = new Subject()
                        {
                            SubjectCode = reader.GetString("SubjectCode"),
                            SubjectName = reader.GetString("SubjectName"),
                        },
                        IsReview = reader.GetBoolean("Review")
                    });
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
            return tests;
        }

        public int CountTests(string subjectCode, DateTime createFrom, DateTime createTo,
            DateTime testFrom, DateTime testTo, string status)
        {
            string table_rowNum = @"SELECT ROW_NUMBER() OVER (ORDER BY [ID] ASC) as rownum, * 
                                    FROM [Test]
                                    WHERE 1=1 ";
            if (subjectCode != null && !subjectCode.Equals(""))
            {
                table_rowNum += " AND [Test].[SubjectCode] = @subjectCode ";
            }
            if (createFrom != new DateTime() && createTo != new DateTime())
            {
                table_rowNum += " AND [Test].[CreateDate] between @createFrom and @createTo ";
            }
            if (testFrom != new DateTime() && testTo != new DateTime())
            {
                table_rowNum += " AND [Test].[TestDate] between @testFrom and @testTo ";
            }

            if (status != null && status.Equals("Started"))
            {
                table_rowNum += @" AND (CAST(TestDate AS datetime) + CAST(StartTime AS datetime)) < GETDATE()
                                    AND (CAST(TestDate AS datetime) + CAST(EndTime AS datetime)) > GETDATE() ";
            }
            else if (status != null && status.Equals("Ended"))
            {
                table_rowNum += @" AND (CAST(TestDate AS datetime) + CAST(EndTime AS datetime)) <= GETDATE() ";
            }
            else if (status != null && status.Equals("Not Started"))
            {
                table_rowNum += @" AND (CAST(TestDate AS datetime) + CAST(StartTime AS datetime)) >= GETDATE() ";
            }

            string sql_select_test = @$"SELECT COUNT(rownum) as total
                                        FROM ({table_rowNum}) as p";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_test, connection);
                if (subjectCode != null && !subjectCode.Equals(""))
                {
                    command.Parameters.AddWithValue("@subjectCode", subjectCode);
                }
                if (createFrom != new DateTime() && createTo != new DateTime())
                {
                    command.Parameters.AddWithValue("@createFrom", createFrom);
                    command.Parameters.AddWithValue("@createTo", createTo);
                }
                if (testFrom != new DateTime() && testTo != new DateTime())
                {
                    command.Parameters.AddWithValue("@testFrom", testFrom);
                    command.Parameters.AddWithValue("@testTo", testTo);
                }
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32("total");
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
            return 0;
        }

        public List<Test> GetTests()
        {
            List<Test> tests = new List<Test>();
            string sql = @"SELECT [Id]
                                  ,[Code]
                                  ,[StartTime]
                                  ,[TestDate]
                                  ,[Duration]
                                  ,s.[SubjectCode]
	                              ,s.[SubjectName]
                                  ,[CreateDate]
                                  ,[EndTime]
                                  ,[Review]
                              FROM [Test] t INNER JOIN [Subject] s ON t.[SubjectCode] = s.[SubjectCode]";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql, connection);
                connection.Open();
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Test test = new Test()
                        {
                            Id = reader.GetInt32("Id"),
                            Code = reader.GetString("Code"),
                            StartTime = (TimeSpan)reader["StartTime"],
                            TestDate = reader.GetDateTime("TestDate"),
                            Duration = (TimeSpan)reader["Duration"],
                            Subject = new Subject()
                            {
                                SubjectCode = reader.GetString("SubjectCode"),
                                SubjectName = reader.GetString("SubjectName")
                            },
                            CreateDate = reader.GetDateTime("CreateDate"),
                            EndTime = (TimeSpan)reader["EndTime"],
                            IsReview = reader.GetBoolean("Review")
                        };
                        tests.Add(test);
                    }
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
            return tests;
        }


        public int ChangeTestTime(Test test)
        {
            int rowAffects = 0;
            string sql_update_test = @"UPDATE [Test]
                               SET [TestDate] = @testDate
                                  ,[StartTime] = @startTime
                                  ,[EndTime] = @endTime
                             WHERE Test.Id=@testId";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_update_test, connection);
                command.Parameters.AddWithValue("@testId", test.Id);
                command.Parameters.AddWithValue("@testDate", test.TestDate);
                command.Parameters.AddWithValue("@startTime", test.StartTime);
                command.Parameters.AddWithValue("@endTime", test.EndTime);
                connection.Open();
                rowAffects = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return rowAffects;
        }

        public int InsertTest(Test test)
        {
            int row = 0;
            string sql_insert_test = @"INSERT INTO [Test]
                                                   ([Code]
                                                   ,[StartTime]
                                                   ,[TestDate]
                                                   ,[Duration]
                                                   ,[SubjectCode]
                                                   ,[CreateDate]
                                                   ,[EndTime]
                                                   ,[Review])
                                             VALUES
                                                   (@code
                                                   ,@starttime
                                                   ,@testdate
                                                   ,@duration
                                                   ,@subjectcode
                                                   ,@createdate
                                                   ,@endtime
                                                   ,@review)";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_insert_test, connection);
                command.Parameters.AddWithValue("@code", test.Code);
                command.Parameters.AddWithValue("@starttime", test.StartTime);
                command.Parameters.AddWithValue("@testdate", test.TestDate);
                command.Parameters.AddWithValue("@duration", test.Duration);
                command.Parameters.AddWithValue("@subjectcode", test.Subject.SubjectCode);
                command.Parameters.AddWithValue("@createdate", test.CreateDate);
                command.Parameters.AddWithValue("@endtime", test.EndTime);
                command.Parameters.AddWithValue("@review", test.IsReview);
                connection.Open();
                row = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return row;
        }

        public int GetLatestTestId()
        {
            string sql = @"SELECT TOP 1 [Id]
                                  FROM [Test]
                                  ORDER BY [Id] desc";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql, connection);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32("Id");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { 
                connection.Close(); 
            }
            return 0;
        }
    }
}
