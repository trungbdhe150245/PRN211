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
        public Test GetTestByCode (string testCode)
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
            } finally
            {
                connection.Close();
            }
            return row;
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
                    while(reader.Read())
                    {
                        Subject subject = new Subject
                        {
                            SubjectCode = reader.GetString("SubjectCode"),
                            SubjectName = reader.GetString("SubjectName"),
                        };
                        Test test = new Test()
                        {
                            Id = reader.GetInt32("id"),
                            Code = reader.GetString("code"),
                            StartTime = (TimeSpan)reader["StartTime"],
                            TestDate = reader.GetDateTime("TestDate").Date,
                            Duration = (TimeSpan)reader["Duration"],
                            Subject = subject,
                            CreateDate = reader.GetDateTime("CreateDate"),
                            EndTime = (TimeSpan)reader["EndTime"],
                            IsReview = reader.GetBoolean("Review"),
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

        //public int GetTotalQuestion(int testId)
        //{
        //    int totalQuestion = 0;
        //    string sql = @"SELECT t.[Id], COUNT(QuestionId) as TotalQuest
        //                    FROM Test t INNER JOIN [Question_Test] qt ON t.[Id] = qt.[TestId]
			     //                       INNER JOIN Question q ON qt.[QuestionId] = q.[Id]
			     //                       INNER JOIN [Level] l ON q.[Level] = l.[Id]
        //                    GROUP BY t.[Id]
        //                    HAVING t.[Id] = @testId";
        //    try
        //    {
        //        connection = new SqlConnection(GetConnectionString());
        //        command = new SqlCommand(sql, connection);
        //        command.Parameters.AddWithValue("@testId", testId);
        //        connection.Open();
        //        reader = command.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            totalQuestion = reader.GetInt32("TotalQuest");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }
        //    return totalQuestion;
        //}


    }
}
