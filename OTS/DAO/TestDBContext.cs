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

        public Test GetTest(int stuId)
        {
            string sql_select_test = @$"SELECT Test.Id,Code,StartTime,Test.Duration,SubjectCode,CreateDate,Review,EndTime FROM Test JOIN Submission ON Test.Id = Submission.TestId WHERE StudentId = {stuId}";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_test, connection);

                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return new Test()
                    {
                        Id = reader.GetInt32(0),
                        Code = reader.GetString(1),
                        CreateDate = reader.GetDateTime(5),
                        TestDate = reader.GetDateTime(8),
                        StartTime = reader.GetTimeSpan(2),
                        Duration = reader.GetTimeSpan(3),
                        Subject = new Subject()
                        {
                            SubjectCode = reader.GetString(4),
                            SubjectName = reader.GetString(9),
                        },
                        IsReview = reader.GetBoolean(10),
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
