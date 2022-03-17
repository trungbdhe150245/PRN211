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
                                                   ,[Review])
                                             VALUES
                                                   (@code,
                                                   ,@starttime
                                                   ,@testdate
                                                   ,@duration
                                                   ,@subjectcode
                                                   ,@createdate
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
                        Subject subject = new Subject()
                        {
                            SubjectCode = reader.GetString(6),
                            SubjectName = reader.GetString(7)
                        };

                        Test test = new Test()
                        {
                            Id = reader.GetInt32(1),
                            Code = reader.GetString(2),
                            StartTime = reader.GetTimeSpan(3),
                            TestDate = reader.GetDateTime(4),
                            Duration = reader.GetTimeSpan(5),
                            Subject = subject,
                            CreateDate = reader.GetDateTime(8),
                            IsReview = reader.GetBoolean(9)
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
    }
}
