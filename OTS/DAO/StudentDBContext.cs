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
    public class StudentDBContext : DBContext
    {
        public Student GetStudent(string username, string password)
        {
            try
            {
                string sql = @"SELECT [Id]
                                  ,[FullName]
                                  ,[Password]
                                  ,[Dob]
                                  ,[StudentCode]
                                  , c.[ClassCode]
	                              ,c.[ClassName]
                              FROM[Student] s INNER JOIN[Class] c ON s.ClassCode = c.ClassCode
                              WHERE BINARY_CHECKSUM([StudentCode]) = BINARY_CHECKSUM(@username)
                                and BINARY_CHECKSUM([Password]) = BINARY_CHECKSUM(@password)";
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();

                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    Student student = new Student
                    {
                        Id = reader.GetInt32("Id"),
                        FullName = reader.GetString("FullName"),
                        Password = reader.GetString("Password"),
                        DateOfBirth = reader.GetDateTime("Dob"),
                        StudentCode = reader.GetString("StudentCode")
                    };
                    Class @class = new Class
                    {
                        ClassCode = reader.GetString("ClassCode"),
                        ClassName = reader.GetString("ClassName")
                    };
                    student.Class = @class;
                    return student;
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
