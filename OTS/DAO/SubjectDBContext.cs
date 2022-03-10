using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
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
        public int UpdateSubject(String oldsubjectCode, String oldsubjectName,String newsubjectCode,String newsubjectName)
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
        public int FindSubject(String option,String subjectCode,String subjectName,DataGridView gdvUpdateSubject)
        {
            int rowAffects = 0;
            string sql_view_subject = "";
            if (option=="FindBySubjectCode")
            {
                 sql_view_subject = @"Select [SubjectCode]
                                        from Subject
                                        Where SubjectCode=@subjectCode;";
            }
            else
            {
                 sql_view_subject = @"Select [SubjectName]
                                        from Subject
                                        Where SubjectName=@subjectName;";
            }
            
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(@sql_view_subject, connection);
                
                
                if (option == "FindBySubjectCode")
                {
                   command.Parameters.AddWithValue("@subjectCode", subjectCode);
                }
                else
                {
                   command.Parameters.AddWithValue("@subjectName", subjectName);
                }


                try
                {
                    SubjectDBContext subjectDBContext = new SubjectDBContext();
                    gdvUpdateSubject.DataSource = subjectDBContext.GetConnectionString();
                    gdvUpdateSubject.AutoGenerateColumns = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                        subject.SubjectName = reader.GetString("SubjectName");
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }
            return subjects;
        }

    }
}

