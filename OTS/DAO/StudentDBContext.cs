﻿using Microsoft.Data.SqlClient;
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
        public int UpdateStudent(String Id, String FullName, String Password, DateTime Dob, String StudentCode, String ClassCode)
        {
            int rowAffects = 0;
            String sql_update_student = "UPDATE [Student] SET [FullName]=@FullName, [Password]=@pass, [Dob]=@Dob, [StudentCode]=@stuCode, [ClassCode]=@classCode WHERE [Id]=@id;";


            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_update_student, connection);


                command.Parameters.AddWithValue("@FullName", FullName);
                command.Parameters.AddWithValue("@pass", Password);
                command.Parameters.AddWithValue("@Dob", Dob);
                command.Parameters.AddWithValue("@stuCode", StudentCode);
                command.Parameters.AddWithValue("@classCode", ClassCode);
                command.Parameters.AddWithValue("@id", Id);


                connection.Open();
                rowAffects++;
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
        public int DeleteStudent(String Id)
        {
            int rowAffects = 0;
            string sql_delete_student = "";

            sql_delete_student = @"DELETE FROM Student  WHERE Id = @Id ;";

            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_delete_student, connection);
                command.Parameters.AddWithValue("@Id", Id);

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
            else if (option == "ClassCodeAndStudentCode")
            {
                sql_view_student = @"SELECT  [Id]
                                            ,[FullName]
                                            ,[Password]
                                            ,[Dob]
                                            ,[StudentCode]
                                            ,[ClassCode]
                                            FROM [Student] Where [ClassCode]=@classCode And [StudentCode]=@studentCode;";
            }



            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_view_student, connection);


                if (option == "ClassCode")
                {
                    command.Parameters.AddWithValue("@classCode", classCode);
                }
                else if (option == "StudentCode")
                {
                    command.Parameters.AddWithValue("@studentCode", StudentCode);
                }
                else if (option == "ClassCodeAndStudentCode")
                {
                    command.Parameters.AddWithValue("@classCode", classCode);
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
        public Student GetStudent(int id)
        {
            int rowAffects = 0;
            string sql_view_student = "";
            Student stu = new Student();

            sql_view_student = @"SELECT      [Id]
                                            ,[FullName]
                                            ,[Password]
                                            ,[Dob]
                                            ,[StudentCode]
                                            ,[ClassCode]
                                            FROM [Student] Where [Id]=@id;";

            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_view_student, connection);

                command.Parameters.AddWithValue("@Id", id);

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

                            stu = students;
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
