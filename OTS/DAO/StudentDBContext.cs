using Microsoft.Data.SqlClient;
using OTS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS.DAO
{
    public class StudentDBContext : DBContext 
    {
        public Student getStudent(int id)
        {
            string getStu = @$"SELECT [Id]
      ,[FullName]
      ,[Password]
      ,[Dob]
      ,[StudentCode]
      ,[ClassCode]
  FROM [dbo].[Student] WHERE Id = {id}";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(getStu, connection);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        ClassDBContext cDb = new ClassDBContext();
                        Class c = cDb.getClassbyId(reader.GetString(5));
                        Student stu = new Student()
                        {
                            Id = id,
                            FullName = reader.GetString(1),
                            Password = reader.GetString(2),
                            DateOfBirth = reader.GetDateTime(3),
                            StudentCode = reader.GetString(4),
                            Class = c
                            
                        };
                        return stu;
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
            return null;
        }
    }
}
