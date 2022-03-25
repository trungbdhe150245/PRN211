using Microsoft.Data.SqlClient;
using OTS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS.DAO
{
    public class LevelDBContext : DBContext
    {
        public Level GetLevel(int id)
        {
            string sql = @"SELECT [Id]
                                  ,[Name]
                              FROM [Level]
                              WHERE [Id] = @id";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Level level = new()
                    {
                        Id = (short)reader["Id"],
                        Name = (string)reader["Name"],
                    };
                    return level;
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
