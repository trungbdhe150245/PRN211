﻿using Microsoft.Data.SqlClient;
using OTS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = OTS.Models.Type;

namespace OTS.DAO
{
    public class QuestionDBContext : DBContext 
    {
        public string Content { get; private set; }

        public List<QuestionTest> GetQuestionByTests(int testID)
        {
            List<QuestionTest> result = new List<QuestionTest>();
            string sql_select_question = @"";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_question, connection);

                connection.Open();
                reader = command.ExecuteReader();
                Test test = null;
                while (reader.Read())
                {
                    if(test == null)
                    {
                        test = new Test()
                        {
                            Id = reader.GetInt32(""),
                        };
                    }
                    Question question = new Question()
                    {
                        Id = reader.GetInt32(""),
                        Content = reader.GetString(""),
                        Level = new Level()
                        {
                            Name = reader.GetString(""),
                        },
                        Type = new Type()
                        {
                            Name = reader.GetString(""),
                        }

                    };
                    result.Add(new QuestionTest()
                    {
                        Question = question,
                        Test = test,
                    });
                }

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { connection.Close(); }
                   
            return result;
        }

        public List<Question> getQuesCorrect()
        {
            List<Question> ListQues = new List<Question>();
            List<Type> listType = new List<Type>();
            string getallQuestion = "SELECT A.Id,A.Content,D.[Name],A.SubjectCode,B.[Name],C.Content,isCorrect FROM Question AS A JOIN[Type] AS B ON A.[Type] = B.IdJOIN Answer AS C on C.QuestionId = A.Id JOIN[Level] AS D ON D.Id = A.[Level]WHERE C.isCorrect = 1";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(getallQuestion, connection);

                connection.Open();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int typeId = reader.GetInt16("B.Id");
                    Type t = new Type()
                    {
                        Id = reader.GetInt16("B.Id"),
                        Name = reader.GetString("B.Name")
                    };
                    Subject s = new Subject()
                    {
                        SubjectCode = reader.GetString("S.SubjectCode"),
                        SubjectName = reader.GetString("S.SubjectName")
                    };
                    Level l = new Level()
                    {
                        Id = reader.GetInt16("D.Id"),
                        Name = reader.GetString("D.[Name]")
                    };
                    Answer a = new Answer()
                    {
                        Id = reader.GetInt32("")
                    };
                    if(!listType.Contains(t))
                    {
                        listType.Add(t);
                    }
                    Question ques = new Question()
                    {
                        Content = reader.GetString("Content"),
                        Type = t,
                        Subject = s,
                        Level = l,

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
            return ListQues;
        }
    }
}
