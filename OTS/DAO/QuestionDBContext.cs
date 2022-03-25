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

        public Question getQues(int id)
        {
            List<Question> ListQues = new List<Question>();
            List<Models.Type> listType = new List<Models.Type>();
            string getallQuestion = @$"SELECT [Id]
      ,[Content]
      ,[Level]
      ,[SubjectCode]
      ,[Type]
  FROM [dbo].[Question] WHERE Id = {id}";
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

                if (reader.Read())
                {
                    Models.Type t = tDB.GetTypeById(reader.GetInt16(4));
                    Subject s = sDB.getSubbyId(reader.GetString(3));
                    Level l = lDB.GetLevelById(reader.GetInt16(2));
                    //List<Answer> answers = aDB.getAnswerByCID(reader.GetInt32(0));
                    Question ques = new Question()
                    {
                        Content = reader.GetString(1),
                        Type = t,
                        Subject = s,
                        Level = l,
                        Id = id,
                        //Answers = aDB.getAnswerByCID(reader.GetInt32(0))
                    };
                    //ques.Answers = answers;
                    return ques;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
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
                rowAffects = Convert.ToInt32(command.ExecuteScalar());

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

        public int UpdateQues(Question targetQues)
        {
            int rowAffects = 0;
            string sql_update_class = @"UPDATE [dbo].[Question]
   SET [Content] = @Content
      ,[Level] = @Level
      ,[SubjectCode] = @Subject
      ,[Type] = @Type
 WHERE Id = @Id";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_update_class, connection);
                command.Parameters.AddWithValue("@Content", targetQues.Content);
                command.Parameters.AddWithValue("@Level", targetQues.Level.Id);
                command.Parameters.AddWithValue("@Subject", targetQues.Subject.SubjectCode);
                command.Parameters.AddWithValue("@Type", targetQues.Type.Id);
                command.Parameters.AddWithValue("@Id", targetQues.Id);
                connection.Open();
                rowAffects = command.ExecuteNonQuery();
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

        public int DeleteQues(Question q)
        {
            int rowAffects = 0;


            string sql_delete_classes = @$"DELETE FROM [dbo].[Question]
      WHERE Id = @Id";

            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_delete_classes, connection);
                command.Parameters.AddWithValue("@Id", q.Id);
                connection.Open();
                rowAffects = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { connection.Close(); }
            return rowAffects;
        }

        public List<Question> getQuesByTest(int testId)
        {
            List<Question> list = new List<Question>();
            string sql_test_ques = @$"SELECT Question.Id,Question.Content,Answer.isCorrect,Answer.Content
FROM Test JOIN Question_Test ON Test.Id = Question_Test.TestId JOIN Question ON Question.Id = Question_Test.QuestionId
JOIN Answer ON Answer.QuestionId = Question.Id
WHERE Test.Id = {testId} AND Answer.isCorrect = 1";
            TypeDBContext tDB = new TypeDBContext();
            SubjectDBContext sDB = new SubjectDBContext();
            LevelDBContext lDB = new LevelDBContext();
            AnswerDBContext aDB = new AnswerDBContext();
            try
            {

                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_test_ques, connection);
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    //List<Answer> answers = aDB.getAnswerByCID(reader.GetInt32(0));
                    Question ques = new Question()
                    {
                        Content = reader.GetString(1),
                        Id = reader.GetInt32(0),
                        
                    };
                    Answer a = new Answer()
                    {
                        IsCorrect = reader.GetBoolean(2),
                        Content = reader.GetString(3)
                    };
                    ques.Answers.Add(a);
                    list.Add(ques);
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
