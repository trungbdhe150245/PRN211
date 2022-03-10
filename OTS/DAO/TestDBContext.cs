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
    public class TestDBContext : DBContext
    {
        public Test GetTest(int testId)
        {
            string sql_select_test = "";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_test, connection);

                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Test()
                    {
                        Id = testId,
                        Code = reader.GetString(""),
                        CreateDate = reader.GetDateTime(""),
                        TestDate = reader.GetDateTime(""),
                      //  StartTime = reader.GetTimeSpan(""),
                      //  Duration = reader.GetTimeSpan(""),
                        Subject = new Subject() { 
                            SubjectCode = reader.GetString(""),
                            SubjectName = reader.GetString(""),
                        },
                        IsReview = reader.GetBoolean("")
                    };
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
