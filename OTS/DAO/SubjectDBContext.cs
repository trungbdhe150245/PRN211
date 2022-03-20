using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using OTS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS.DAO
{
    public class SubjectDBContext : DBContext
    {
        public int InsertSubject(String subjectCode, String subjectName)
        {
            int rowAffects = 0;
            string sql_insert_class = @"INSERT INTO Subject (SubjectCode, SubjectName)
                                        VALUES ('@subjectCode','@subjectName');";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(@sql_insert_class, connection);
                command.Parameters.AddWithValue("@subjectCode", subjectCode);
                command.Parameters.AddWithValue("@subjectName", subjectName);
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


        public List<Subject> subjects()
        {
            List<Subject> subjects = new List<Subject>();
            string getSub = "SELECT [SubjectCode], [SubjectName] FROM [Subject]";
            
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(getSub, connection);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Subject subject = new Subject()
                        {
                            SubjectCode = reader.GetString("SubjectCode"),
                            SubjectName = reader.GetString("SubjectName")
                        };
                        //subject.SubjectCode = reader.GetString("SubjectCode");
                        //subject.SubjectName = reader.GetString("SubjectName");
                        subjects.Add(subject);
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
            return subjects;
        }

        public Subject getSubbyId(string code)
        {
            List<Subject> subs = subjects();
            foreach (var s in subs)
            {
                if (s.SubjectCode.Equals(code))
                {
                    return s;
                }
            }

            return null;
        }

    }
}

