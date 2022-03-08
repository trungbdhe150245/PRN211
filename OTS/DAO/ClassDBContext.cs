using Microsoft.Data.SqlClient;
using OTS.DAO;
using OTS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS.DAO
{
    internal class ClassDBContext : DBContext
    {
        public int UpdateClass(Class targetClass)
        {
            int rowAffects = 0;
            string sql_update_class = "";
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand(sql_update_class, connection);

            connection.Open();
            rowAffects = command.ExecuteNonQuery();
            
            return rowAffects;
        }
        public bool IsClassExist(string className)
        {
            bool isExist = false;

            string sql_select_class = @"SELECT [Id]
                                      ,[Name]
                                  FROM [Class] WHERE NAME = @Name";

            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_class, connection);
                command.Parameters.AddWithValue("@Name", className);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isExist = true;
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                connection.Close();
            }

            return isExist;
        }

        public List<Class> getClasses()
        {
            List<Class> classes = new List<Class>();
            string sql_select_class = @"SELECT [Id]
                                          ,[Name]
                                      FROM [Class]";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_class, connection);
                connection.Open();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Class cls = new Class()
                    {
                        Name = reader.GetString("Name"),
                        Id = reader.GetInt32("Id"),
                    };
                    classes.Add(cls);

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

            return classes;
        }

        public int AddClass(Class newClass)
        {
            int rowAffects = 0;
            string sql_insert_class = @"INSERT INTO [Class]
                                           ([Name])
                                     VALUES (@className)";
            try
            {
                connection=new SqlConnection(GetConnectionString());
                command = new SqlCommand(@sql_insert_class, connection);
                command.Parameters.AddWithValue("@className", newClass.Name);
                connection.Open();
                rowAffects = command.ExecuteNonQuery();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                connection.Close();
            }
            return rowAffects;
        }
    }

}
