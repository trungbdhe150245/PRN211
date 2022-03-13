using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS.DAO
{
    public class SubmissionDBContext : DBContext 
    {
        public bool CheckIsTested(int testId)
        {
            bool result = false;
            string sql_select_submission = @"SELECT [Id]
                                          ,[TestId]
                                          ,[StudentId]
                                          ,[SubmitDate]
                                          ,[Duration]
                                      FROM [Submission]
                                      WHERE TestId=@testId";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_submission, connection);
                command.Parameters.AddWithValue("@testId", testId);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    result = true;
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally { connection.Close(); }
            return result;
        }
    }
}
