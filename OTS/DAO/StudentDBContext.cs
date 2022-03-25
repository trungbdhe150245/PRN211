using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OTS.Models;
namespace OTS.DAO
{
    public class StudentDBContext : DBContext
    {
        public int InsertStudent(String FullName, String Password, DateTime Dob, String StudentCode, String ClassCode)
        {
            int rowAffects = 0;
            string sql_insert_subject = @"INSERT INTO [OTS].[dbo].[Student] (
                                                               [FullName]
                                                              ,[Password]
                                                              ,[Dob]
                                                              ,[StudentCode]
                                                              ,[ClassCode])
                                        VALUES (@name,@password,@dob,@stuCode,@classCode);";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(@sql_insert_subject, connection);

                command.Parameters.AddWithValue("@name", FullName);
                command.Parameters.AddWithValue("@password", Password);
                command.Parameters.AddWithValue("@dob", Dob);
                command.Parameters.AddWithValue("@stuCode", StudentCode);
                command.Parameters.AddWithValue("@classCode", ClassCode);

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
        public int UpdateSubject(String option, String oldsubjectCode, String oldsubjectName, String newsubjectCode, String newsubjectName)
        {
            int rowAffects = 0;
            string sql_update_subject = "";
            if (option.Equals("UpdateCode"))
            {
                sql_update_subject = @"UPDATE Subject
                                       SET SubjectCode = @newCode
                                       WHERE SubjectCode = @oldCode;";
            }
            else if (option.Equals("UpdateName"))
            {
                sql_update_subject = @"UPDATE Subject
                                       SET  SubjectName = @newName
                                       WHERE SubjectCode = @oldCode;";
            }
            else if (option.Equals("UpdateCodeAndName"))
            {
                sql_update_subject = @"UPDATE Subject
                                       SET  SubjectCode = @newCode, SubjectName = @newName
                                       WHERE SubjectCode = @oldsubjectCode;";
            }


            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_update_subject, connection);


                if (option.Equals("UpdateCode"))
                {
                    command.Parameters.AddWithValue("@newCode", newsubjectCode);
                    command.Parameters.AddWithValue("@oldCode", oldsubjectCode);

                }
                else if (option.Equals("UpdateName"))
                {
                    command.Parameters.AddWithValue("@newName", newsubjectName);
                    command.Parameters.AddWithValue("@oldCode", oldsubjectCode);
                }
                else if (option.Equals("UpdateCodeAndName"))
                {
                    command.Parameters.AddWithValue("@newCode", newsubjectCode);
                    command.Parameters.AddWithValue("@newName", newsubjectName);
                    command.Parameters.AddWithValue("@oldCode", oldsubjectCode);
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
        //--------------------------------------------------------
        public int DeleteSubject(String oldsubjectCode)
        {
            int rowAffects = 0;
            string sql_update_subject = "";

            sql_update_subject = @"DELETE FROM Subject  WHERE SubjectCode = @oldCode ;";

            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_update_subject, connection);
                command.Parameters.AddWithValue("@oldCode", oldsubjectCode);

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



        public List<Models.Student> FindStudent(String option, String classCode, String StudentCode)
        {
            int rowAffects = 0;
            string sql_view_student = "";
            List<Models.Student> stu = new List<Models.Student>();
            if (option.Equals("ClassCode"))
            {
                sql_view_student = @"SELECT  [Id]
                                            ,[FullName]
                                            ,[Password]
                                            ,[Dob]
                                            ,[StudentCode]
                                            ,[ClassCode]
                                            FROM [Student] Where [ClassCode]=@classCode;";
            }
            else if (option == "StudentCode")
            {
                sql_view_student = @"SELECT  [Id]
                                            ,[FullName]
                                            ,[Password]
                                            ,[Dob]
                                            ,[StudentCode]
                                            ,[ClassCode]
                                            FROM [Student] Where [StudentCode]=@studentCode;";
            }
            else if (option == "getAll")
            {
                sql_view_student = @"SELECT  [Id]
                                            ,[FullName]
                                            ,[Password]
                                            ,[Dob]
                                            ,[StudentCode]
                                            ,[ClassCode]
                                            FROM [Student] ";
            }



            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_view_student, connection);


                if (option == "FindByclassCode")
                {
                    command.Parameters.AddWithValue("@classCode", classCode);
                }
                else if (option == "FindByStudentCode")
                {
                    command.Parameters.AddWithValue("@studentCode", StudentCode);
                }



                try
                {
                    connection.Open();
                    reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (reader.HasRows == true)
                    {
                        while (reader.Read())
                        {
                            Models.Student students = new Models.Student();
                            students.Id = reader.GetInt32("Id");
                            students.FullName = reader.GetString("FullName");
                            students.Password = reader.GetString("Password");
                            students.DateOfBirth = reader.GetDateTime("Dob");
                            students.StudentCode = reader.GetString("StudentCode");
                            try
                            {
                                Class c = new Class();
                                c.ClassCode = reader.GetString("ClassCode");
                                students.Class = c;

                            }
                            catch (Exception e) { }

                            stu.Add(students);
                        }

                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
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
            return stu;
        }
        //--------------------------------------------------------
        public List<Class> getClassCode()
        {
            
            string sql_view_class = "";
            List<Class> cls = new List<Class>();

            sql_view_class = @"SELECT  [ClassCode]
                                            FROM [Class] ";



            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_view_class, connection);

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        while (reader.Read())
                        {
                            Models.Class classsss = new Models.Class();
                            classsss.ClassCode = reader.GetString("ClassCode");
                            cls.Add(classsss);


                        }

                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                
                
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
            return cls;
        }
    }
}
