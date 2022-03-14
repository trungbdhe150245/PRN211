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
    }
}
