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
using System.Windows.Forms;

namespace OTS.DAO
{
    public class SubjectDBContext : DBContext
    {// Insert for Insert button
        public int InsertSubject(String subjectCode, String subjectName)
        {
            int rowAffects = 0;
            string sql_insert_subject = @"INSERT INTO Subject (SubjectCode, SubjectName)
                                        VALUES (@subjectCode,@subjectName);";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(@sql_insert_subject, connection);
                command.Parameters.AddWithValue("@subjectCode", subjectCode);
                command.Parameters.AddWithValue("@subjectName", subjectName);
                connection.Open();
                rowAffects = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Warnning",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return rowAffects;
        }
        //--------------------------------------------------------
        public int UpdateSubject(String oldsubjectCode, String oldsubjectName, String newsubjectCode, String newsubjectName)
        {
            int rowAffects = 0;
            string sql_insert_subject = @"UPDATE Subject
                                       SET SubjectCode = @newsubjectCode, SubjectName = @newsubjectName
                                       WHERE SubjectCode = @oldsubjectCode and SubjectName = @oldsubjectName;";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(@sql_insert_subject, connection);
                command.Parameters.AddWithValue("@oldsubjectCode", oldsubjectCode);
                command.Parameters.AddWithValue("@oldsubjectName", oldsubjectName);
                command.Parameters.AddWithValue("@newsubjectCode", newsubjectCode);
                command.Parameters.AddWithValue("@newsubjectName", newsubjectName);
                connection.Open();
                rowAffects = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Warnning",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return rowAffects;
        }
        public int FindSubject(String option, String subjectCode, String subjectName, DataGridView gdvUpdateSubject)
        {
            int rowAffects = 0;
            string sql_view_subject = "";
            if (option.Equals("FindBySubjectCode"))
            {
                sql_view_subject = @"Select [SubjectCode]
                                        from Subject
                                        Where SubjectCode=@subjectCode;";
            }
            else if (option == "FindBySubjectName")
            {
                sql_view_subject = @"Select [SubjectName]
                                        from Subject
                                        Where SubjectName=@subjectName;";
            }
            else if (option == "FindBySubjectCodeAndName")
            {
                sql_view_subject = @"Select [SubjectCode],[SubjectName]
                                        from Subject
                                        Where SubjectCode=@subjectCode And SubjectName=@subjectName;";
            }

            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(@sql_view_subject, connection);


                if (option == "FindBySubjectCode")
                {
                    command.Parameters.AddWithValue("@subjectCode", subjectCode);
                }
                else if (option == "FindBySubjectName")
                {
                    command.Parameters.AddWithValue("@subjectName", subjectName);
                }
                else if (option == "FindBySubjectCodeAndName")
                {
                    command.Parameters.AddWithValue("@subjectCode", subjectCode);
                    command.Parameters.AddWithValue("@subjectName", subjectName);
                }

                connection.Open();
                rowAffects = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Warnning",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return rowAffects;
        }

        public List<Models.Subject> Getsubjects()
        {
            List<Models.Subject> subjects = new List<Models.Subject>();
            string sql = @"SELECT [SubjectCode]
                                  ,[SubjectName]
                              FROM [Subject]";
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand(sql, connection);
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
                        subject.SubjectName = reader.GetString("SubjectName");
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

        public Subject GetSubject(string code)
        {
            string sql = @"SELECT [SubjectCode]
                                  ,[SubjectName]
                              FROM [Subject]
                              WHERE [SubjectCode] = @code";

            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@code", code);
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Subject subject = new Subject()
                    {
                        SubjectCode = reader.GetString("SubjectCode"),
                        SubjectName = reader.GetString("SubjectName")
                    };
                    return subject;
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

