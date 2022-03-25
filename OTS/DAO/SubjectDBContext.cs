using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
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


        public List<Models.Subject> subjects()
        {
            List<Models.Subject> subjects = new List<Models.Subject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand();
            try
            {
                connection.Open();
                reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        Models.Subject subject = new Models.Subject();
                        subject.SubjectCode = reader.GetString("SubjectCode");
                        subject.SubjectName = reader.GetString("ClassName");
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

    }
}

