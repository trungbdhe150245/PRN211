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
            string getAnsByQues = $"SELECT [Id], [Content], [QuestionId],[isCorrect] FROM [dbo].[Answer] WHERE QuestionId = {quesId}";
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

        public List<Answer> getCorrectAnswer()
        {
            List<Answer> list = new List<Answer>();
            string getAnsByQues = $"SELECT [Id], [Content], [QuestionId],[isCorrect] FROM [dbo].[Answer] WHERE isCorrect = 1";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(getAnsByQues, connection);

                connection.Open();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Answer a = new Answer()
                    {
                        Content = reader.GetString("Content"),
                        Id = reader.GetInt32("Id"),
                        IsCorrect = reader.GetBoolean("isCorrect"),
                        Question = getQuesById(reader.GetInt32("QuestionId"))
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

        public Question getQuesById(int id)
        {
            QuestionDBContext qDB = new QuestionDBContext();
            Question question = qDB.getQues().Where(q => q.Id == id).FirstOrDefault();
            return question;
        }
    }
}
