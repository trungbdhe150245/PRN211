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
    public class MarkDBContext : DBContext 
    {
        public Mark GetMark(int testId, int studentId)
        {
            try
            {
                string sql_select_Mark = @"SELECT [TestId]
                                          ,[StudentId]
                                              ,[Mark]
                                              ,[Note]
                                          FROM [Mark]
                                          WHERE TestId=@testId AND StudentId=@studentId";
                connection = new SqlConnection(GetConnectionString());
                command =  new SqlCommand(sql_select_Mark, connection);
                command.Parameters.AddWithValue("@testId", testId);
                command.Parameters.AddWithValue("@studentId", studentId);

                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Mark()
                    {
                        Grade = reader.GetFloat("Mark"),
                        Note = reader.GetString("Note"),
                    };
                }
            }catch(Exception ex) { throw new Exception(ex.Message); }
            finally { connection.Close(); }
            return null;
        }
        public int DeleteMark(int testId, int studentId)
        {
            int rowAffects = 0;
            try {
                string sql_delete_Mark = @"DELETE FROM [Mark]
                                     WHERE TestId=@testId AND StudentId=@studentId";
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_delete_Mark, connection);
                command.Parameters.AddWithValue("@testId", testId);
                command.Parameters.AddWithValue("@studentId", studentId);
                connection.Open();
                rowAffects = command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { connection.Close(); }
            return rowAffects;
        }
        public int SetMark(Mark mark)
        {
            int rowAffects = 0;
            try {
                string sql_insert_Mark = @"INSERT INTO [dbo].[Mark]
                                               ([TestId]
                                               ,[StudentId]
                                               ,[Mark]
                                               ,[Note])
                                         VALUES
                                               (@testId
                                               ,@studentId
                                               ,@mark
                                               ,@note)";
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_insert_Mark, connection);
                command.Parameters.AddWithValue("@testId", mark.Test.Id);
                command.Parameters.AddWithValue("@studentId", mark.Student.Id);
                command.Parameters.AddWithValue("@mark", mark.Grade);
                command.Parameters.AddWithValue("@note", mark.Note);
                connection.Open();
                rowAffects = command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { connection.Close(); }
            return rowAffects;
        }

        internal int CountMarks(string testCode, string studentCode, string classCode, DateTime from, DateTime to)
        {
            string table_rowNum = @"SELECT ROW_NUMBER() OVER (ORDER BY m.[TestId] ASC) as rownum
	                                      ,m.[TestId]
                                          ,m.[StudentId]
                                          ,[Mark]
                                          ,[Note]
	                                      ,t.[Code]
	                                      ,s.StudentCode
	                                      ,s.FullName
	                                      ,c.ClassCode
	                                      ,c.ClassName
	                                      ,sm.SubmitDate
                                      FROM [Mark]m
                                      JOIN [Test] t ON m.TestId = t.Id
                                      JOIN [Student] s ON m.StudentId = s.Id
                                      JOIN [Class] c ON s.ClassCode = c.ClassCode
                                      JOIN [Submission] sm ON (m.TestId = sm.TestId AND m.StudentId = sm.StudentId)
                                      WHERE 1=1 ";
            if (testCode != null && !testCode.Equals(""))
            {
                table_rowNum += $" AND t.[Code] = '{testCode}' ";
            }
            if (studentCode != null && !studentCode.Equals(""))
            {
                table_rowNum += $" AND s.[StudentCode] = '{studentCode}' ";
            }
            if (classCode != null && !classCode.Equals(""))
            {
                table_rowNum += $" AND c.[ClassCode] = '{classCode}' ";
            }
            if (from != new DateTime() && to != new DateTime())
            {
                table_rowNum += $" AND CAST(sm.SubmitDate AS date) between CAST('{from}' AS date) and CAST('{to}' AS date) ";
            }

            string sql_select_test = @$"SELECT COUNT(rownum) as total
                                        FROM ({table_rowNum}) as p ";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_test, connection);
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

        public List<Mark> GetMarks(int pageIndex, int pageSize, string testCode, string studentCode
            , string classCode, DateTime from, DateTime to)
        {
            List<Mark> marks = new List<Mark>();

            string table_rowNum = @"SELECT ROW_NUMBER() OVER (ORDER BY m.[TestId] ASC) as rownum
	                                      ,m.[TestId]
                                          ,m.[StudentId]
                                          ,[Mark]
                                          ,[Note]
	                                      ,t.[Code]
	                                      ,s.StudentCode
	                                      ,s.FullName
	                                      ,c.ClassCode
	                                      ,c.ClassName
	                                      ,sm.SubmitDate
                                      FROM [Mark]m
                                      JOIN [Test] t ON m.TestId = t.Id
                                      JOIN [Student] s ON m.StudentId = s.Id
                                      JOIN [Class] c ON s.ClassCode = c.ClassCode
                                      JOIN [Submission] sm ON (m.TestId = sm.TestId AND m.StudentId = sm.StudentId)
                                      WHERE 1=1 ";
            if (testCode != null && !testCode.Equals(""))
            {
                table_rowNum += $" AND t.[Code] = '{testCode}' ";
            }
            if (studentCode != null && !studentCode.Equals(""))
            {
                table_rowNum += $" AND s.[StudentCode] = '{studentCode}' ";
            }
            if (classCode != null && !classCode.Equals(""))
            {
                table_rowNum += $" AND c.[ClassCode] = '{classCode}' ";
            }
            if (from != new DateTime() && to != new DateTime())
            {
                table_rowNum += $" AND CAST(sm.SubmitDate AS date) between CAST('{from}' AS date) and CAST('{to}' AS date) ";
            }

            string sql_select_test = @$"SELECT *
                                  FROM ({table_rowNum}) as p 
                                  WHERE p.rownum >= ({pageIndex} - 1)*{pageSize} + 1
                                        AND p.rownum <= {pageIndex}*{pageSize} ";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_test, connection);
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    marks.Add(new Mark()
                    {
                        Test = new Test
                        {
                            Id = reader.GetInt32("TestId"),
                            Code = reader.GetString("Code")
                        },
                        Student = new Student
                        {
                            Id = reader.GetInt32("StudentId"),
                            StudentCode = reader.GetString("StudentCode"),
                            FullName = reader.GetString("FullName"),
                            Class = new Class
                            {
                                ClassCode = reader.GetString("ClassCode"),
                                ClassName = reader.GetString("ClassName")
                            }
                        },
                        Grade = reader.GetFloat("Mark"),
                        Note = reader.GetString("Note")
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
            return marks;
        }
    }
}
