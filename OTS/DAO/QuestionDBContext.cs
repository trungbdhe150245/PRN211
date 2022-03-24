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

        public List<Question> getQues(string searchKey, string option)
        {
            string whereQuery = "";
            switch (option)
            {
                case "content":
                    whereQuery = " [Content] Like '%' + @content + '%'";
                    break;
                case "code":
                    whereQuery = " [SubjectCode] Like '%' +  @code + '%'";
                    break;
                default: whereQuery = " (1=1) "; break;
            }
            List<Question> ListQues = new List<Question>();
            List<Models.Type> listType = new List<Models.Type>();
            string getallQuestion = @$"SELECT Question.Id,Question.Content,Level.[Name],Question.SubjectCode,Type.[Name],Question.Content,Level.Id,Question.[Type] FROM Question JOIN [Type] ON Question.[Type] = Type.Id  JOIN [Level] ON Level.Id = Question.[Level] WHERE {whereQuery}";
            TypeDBContext tDB = new TypeDBContext();
            SubjectDBContext sDB = new SubjectDBContext();
            LevelDBContext lDB = new LevelDBContext();
            AnswerDBContext aDB = new AnswerDBContext();
            try
            {

                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(getallQuestion, connection);
                switch (option)
                {
                    case "content":
                        command.Parameters.AddWithValue("@content", searchKey);
                        break;
                    case "code":
                        command.Parameters.AddWithValue("@code", searchKey);
                        break;
                }
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Models.Type t = tDB.GetTypeById(reader.GetInt16(7));
                    Subject s = sDB.getSubbyId(reader.GetString(3));
                    Level l = lDB.GetLevelById(reader.GetInt16(6));
                    //List<Answer> answers = aDB.getAnswerByCID(reader.GetInt32(0));
                    Question ques = new Question()
                    {
                        Content = reader.GetString(1),
                        Type = t,
                        Subject = s,
                        Level = l,
                        Id = reader.GetInt32(0),
                        //Answers = aDB.getAnswerByCID(reader.GetInt32(0))
                    };
                    //ques.Answers = answers;
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

        public List<Question> getAll()
        {
            List<Question> ListQues = new List<Question>();
            List<Models.Type> listType = new List<Models.Type>();
            string getallQuestion = @$"SELECT Question.Id,Question.Content,Level.[Name],Question.SubjectCode,Type.[Name],Question.Content,Level.Id,Question.[Type] FROM Question JOIN [Type] ON Question.[Type] = Type.Id  JOIN [Level] ON Level.Id = Question.[Level]";
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
                    //List<Answer> answers = aDB.getAnswerByCID(reader.GetInt32(0));
                    Question ques = new Question()
                    {
                        Content = reader.GetString(1),
                        Type = t,
                        Subject = s,
                        Level = l,
                        Id = reader.GetInt32(0),
                        //Answers = aDB.getAnswerByCID(reader.GetInt32(0))
                    };
                    //ques.Answers = answers;
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

        public int AddQues(Question q)
        {
            int rowAffects = 0;
            string sql_inser_ques = @"INSERT INTO [dbo].[Question]
           ([Content]
           ,[Level]
           ,[SubjectCode]
           ,[Type])
            VALUES
           (@Content
           ,@Level
           ,@SubjectCode
           ,@Type);SELECT SCOPE_IDENTITY();";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_inser_ques, connection);
                command.Parameters.AddWithValue("@Content", q.Content);
                command.Parameters.AddWithValue("@Level", q.Level.Id);
                command.Parameters.AddWithValue("@SubjectCode", q.Subject.SubjectCode);
                command.Parameters.AddWithValue("@Type", q.Type.Id);
                connection.Open();
                rowAffects =Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return rowAffects;
        }

        //public int getId()
        //{

        //}

        //public Question findQuesID(int id)
        //{
        //    List<Question> list = getQues();
        //    Question q = getQues().FirstOrDefault(q => q.Id == id);
        //    return q;
        //}
    }
}
