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
        public List<Answer> getAnswer()
        {
            List<Answer> list = new List<Answer>();
            QuestionDBContext qDb = new QuestionDBContext();
            string getAnsByQues = $"SELECT [Id], [Content], [QuestionId],[isCorrect] FROM [Answer]";
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
                        IsCorrect = reader.GetBoolean("isCorrect"),
                        Question = q
                    };
                    list.Add(a);
                }
                //Question q = qDb.findQuesID(id);
                //q.Answers = list;
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

        //public Answer getCorrect(int id)
        //{
        //    List<Answer> list = getAnswerByCID(id);
        //    foreach (var item in list)
        //    {
        //        if(item.IsCorrect)
        //        {
        //            return item;
        //        }
        //    }
        //    return null;
        //}
    }
}
