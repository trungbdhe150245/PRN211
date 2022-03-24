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
    public class SubmissionDBContext : DBContext 
    {
        public bool CheckIsTested(int testId)
        {
            bool result = false;
            string sql_select_submission = @"SELECT [Id]
                                          ,[TestId]
                                          ,[StudentId]
                                          ,[SubmitDate]
                                          ,[Duration]
                                      FROM [Submission]
                                      WHERE TestId=@testId";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_submission, connection);
                command.Parameters.AddWithValue("@testId", testId);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    result = true;
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally { connection.Close(); }
            return result;
        }

        public Submission GetSubmission(int submitID)
        {
            string sql_select_test = @"SELECT s.[Id]
                                              ,[TestId]
                                              ,[StudentId]
                                              ,[SubmitDate]
	                                          , t.[Code]
	                                          , t.TestDate
	                                          , t.Review
	                                          , stu.StudentCode
	                                          , stu.FullName
	                                          , stu.ClassCode
	                                          , sj.SubjectCode
	                                          , sj.SubjectName
                                          FROM [Submission] s 
                                          JOIN [TEST] t ON s.TestId = t.Id
                                          JOIN [Student] stu ON s.StudentId = stu.Id
                                          JOIN [Subject] sj ON t.SubjectCode = sj.SubjectCode
                                          WHERE s.[Id] = @submissionID";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_test, connection);
                command.Parameters.AddWithValue("@submissionID", submitID);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Submission()
                    {
                        Id = reader.GetInt32("Id"),
                        SubmitDate = reader.GetDateTime("SubmitDate"),
                        Test = new Test
                        {
                            Id = reader.GetInt32("TestId"),
                            Code = reader.GetString("Code"),
                            TestDate = reader.GetDateTime("TestDate"),
                            IsReview = reader.GetBoolean("Review"),
                            Subject = new Subject
                            {
                                SubjectCode = reader.GetString("SubjectCode"),
                                SubjectName = reader.GetString("SubjectName")
                            }
                        },
                        Student = new Student
                        {
                            Id = reader.GetInt32("StudentId"),
                            StudentCode = reader.GetString("StudentCode"),
                            FullName = reader.GetString("FullName"),
                            Class = new Class
                            {
                                ClassCode = reader.GetString("ClassCode")
                            }
                        }
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

        public Submission GetSubmission(int testId, int studentId)
        {
            string sql_select_test = @$"SELECT s.[Id]
                                              ,[TestId]
                                              ,[StudentId]
                                              ,[SubmitDate]
	                                          , t.[Code]
	                                          , t.TestDate
	                                          , t.Review
	                                          , stu.StudentCode
	                                          , stu.FullName
	                                          , stu.ClassCode
	                                          , sj.SubjectCode
	                                          , sj.SubjectName
                                          FROM [Submission] s 
                                          JOIN [TEST] t ON s.TestId = t.Id
                                          JOIN [Student] stu ON s.StudentId = stu.Id
                                          JOIN [Subject] sj ON t.SubjectCode = sj.SubjectCode
                                          WHERE [TestId] = {testId} AND [StudentId] = {studentId} ";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_test, connection);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Submission()
                    {
                        Id = reader.GetInt32("Id"),
                        SubmitDate = reader.GetDateTime("SubmitDate"),
                        Test = new Test
                        {
                            Id = reader.GetInt32("TestId"),
                            Code = reader.GetString("Code"),
                            TestDate = reader.GetDateTime("TestDate"),
                            IsReview = reader.GetBoolean("Review"),
                            Subject = new Subject
                            {
                                SubjectCode = reader.GetString("SubjectCode"),
                                SubjectName = reader.GetString("SubjectName")
                            }
                        },
                        Student = new Student
                        {
                            Id = reader.GetInt32("StudentId"),
                            StudentCode = reader.GetString("StudentCode"),
                            FullName = reader.GetString("FullName"),
                            Class = new Class
                            {
                                ClassCode = reader.GetString("ClassCode")
                            }
                        }
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
