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
    public class AnswerDBContext : DBContext
    {
        public List<Answer> getAnswerByQues(int quesId)
        {
            List<Answer> list = new List<Answer>();
            string getAnsByQues = @"SELECT A.Id,A.Content,A.QuestionId,A.isCorrect 
                                    FROM Answer AS A 
                                    INNER JOIN Question AS B 
                                    ON A.QuestionId = B.Id 
                                    WHERE B.Id = " + quesId;
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(getAnsByQues, connection);

                connection.Open();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Question q = new Question();
                    q.Id = reader.GetInt32("QuestionId");
                    Answer a = new Answer()
                    {
                        Content = reader.GetString("Content"),
                        Id = reader.GetInt32("Id"),
                        Question = q,
                        IsCorrect = reader.GetBoolean("isCorrect")
                    };
                    list.Add(a);
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
            return list;
        }
    }
}
