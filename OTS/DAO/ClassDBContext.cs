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
    internal class ClassDBContext:DBContext
    {
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
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                connection.Close();
            }

            return classes;
        }
    }

}
