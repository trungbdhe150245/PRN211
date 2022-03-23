using Microsoft.Data.SqlClient;
using OTS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS.DAO
{
    public class TypeDBContext : DBContext 
    {
        public List<Models.Type> GetType()
        {
            List<Models.Type> types = new List<Models.Type>();
            string sql = @"SELECT [Id]
                                  ,[Name]
                              FROM [Type]";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql, connection);
                connection.Open();
                reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Models.Type t = new()
                        {
                            Id = (short)reader["ID"],
                            Name = (string)reader["Name"],
                        };
                        types.Add(t);
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
            return types;
        }
    }
}
