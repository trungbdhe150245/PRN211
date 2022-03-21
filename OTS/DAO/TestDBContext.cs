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
            } catch (Exception ex) { throw new Exception(ex.Message); }
            finally {connection.Close();}

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
                        Subject = new Subject() { 
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

        public List<Test> GetTests()
        {
            List<Test> tests = new List<Test>();
            string sql_select_test = @"SELECT [Id]
                                      ,[Code]
                                      ,[StartTime]
                                      ,[EndTime]
                                      ,[TestDate]
                                      ,[Duration]
                                      ,Test.[SubjectCode]
	                                  ,Subject.SubjectName
                                      ,[CreateDate]
                                      ,[Review]
                                  FROM [Test] INNER JOIN Subject
			                                ON Subject.SubjectCode=Test.SubjectCode
                                  WHERE 1=1";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_test, connection);
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
                        StartTime = (TimeSpan)reader["StartTime"],
                        EndTime = (TimeSpan)reader["EndTime"],
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

        public List<Test> GetTests(int pageIndex, int pageSize, string subjectCode
            , DateTime createFrom, DateTime createTo, DateTime testFrom, DateTime testTo, string status)
        {
            List<Test> tests = new List<Test>();

            string table_rowNum = @"SELECT ROW_NUMBER() OVER (ORDER BY [ID] ASC) as rownum, * 
                                    FROM [Test]
                                    WHERE 1=1 ";
            
            if (!subjectCode.Equals(""))
            {
                table_rowNum += " AND [Test].[SubjectCode] = @subjectCode ";
            }
            if (createFrom != null && createTo != null)
            {
                table_rowNum += " AND [Test].[CreateDate] between @createFrom and @createTo ";
            }
            if (testFrom != null && testTo != null)
            {
                table_rowNum += " AND [Test].[TestDate] between @testFrom and @testTo ";
            }

            if (status.Equals("Started"))
            {
                table_rowNum += @" AND (CAST(TestDate AS datetime) + CAST(StartTime AS datetime)) < GETDATE()
                                    AND (CAST(TestDate AS datetime) + CAST(EndTime AS datetime)) > GETDATE() ";
            } 
            else if (status.Equals("Ended"))
            {
                table_rowNum += @" AND (CAST(TestDate AS datetime) + CAST(EndTime AS datetime)) <= GETDATE() ";
            }
            else if (status.Equals("Not Started"))
            {
                table_rowNum += @" AND (CAST(TestDate AS datetime) + CAST(StartTime AS datetime)) >= GETDATE() ";
            }


            string sql_select_test = @$"SELECT [Id]
                                      ,[Code]
                                      ,[StartTime]
                                      ,[EndTime]
                                      ,[TestDate]
                                      ,[Duration]
                                      ,Test.[SubjectCode]
	                                  ,Subject.SubjectName
                                      ,[CreateDate]
                                      ,[Review]
                                  FROM ({table_rowNum}) as p INNER JOIN Subject
			                                ON Subject.SubjectCode=Test.SubjectCode
                                  WHERE 1=1";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_test, connection);
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


        public int StartTest(Test test)
        {
            int rowAffects = 0;
            string sql_update_test = @"UPDATE [Test]
                               SET [StartTime] = GETDATE()
                                  ,[StartTime] = @endTime
                             WHERE Test.Id=@testId";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_update_test, connection);
                command.Parameters.AddWithValue("@testId", test.Id);
                command.Parameters.AddWithValue("@endTime", test.EndTime);
                connection.Open();
                rowAffects = command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { connection.Close(); }

            return rowAffects;
        }
    }
}
