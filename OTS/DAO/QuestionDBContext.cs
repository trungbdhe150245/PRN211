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
    public class QuestionDBContext : DBContext 
    {
        //public string Content { get; private set; }

        public List<Question> getQues()
        {
            List<Question> ListQues = new List<Question>();
            List<Models.Type> listType = new List<Models.Type>();
            string getallQuestion = "SELECT Question.Id,Question.Content,Level.[Name],Question.SubjectCode,Type.[Name],Question.Content,Level.Id,Question.[Type] FROM Question JOIN [Type] ON Question.[Type] = Type.Id  JOIN [Level] ON Level.Id = Question.[Level]";
            TypeDBContext tDB = new TypeDBContext();
            SubjectDBContext sDB = new SubjectDBContext();
            LevelDBContext lDB = new LevelDBContext();
            AnswerDBContext aDB = new AnswerDBContext();
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(getallQuestion, connection);
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Models.Type t = tDB.GetTypeById(reader.GetInt16(7));
                    Subject s = sDB.getSubbyId(reader.GetString(3));
                    Level l = lDB.GetLevelById(reader.GetInt16(6));
                    List<Answer> answers = aDB.getAnswerByQues(reader.GetInt32(0));
                    Question ques = new Question()
                    {
                        Content = reader.GetString(1),
                        Type = t,
                        Subject = s,
                        Level = l,
                        Answers = answers,
                        Id = reader.GetInt32(0)
                    };
                    foreach (var ans in answers)
                    {
                        ans.Question = ques;
                    }
                    ListQues.Add(ques);
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
            return ListQues;
        }
    }
}
