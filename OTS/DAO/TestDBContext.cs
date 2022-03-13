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
                                  WHERE Test.Id = @TestId";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_test, connection);
                command.Parameters.AddWithValue("@TestId", testId);
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
    }
}
