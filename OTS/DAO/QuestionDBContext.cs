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

        public Question GetQuestion(int questionId)
        {
            string sql_select_question = @"SELECT  Question.[Id]
                                      ,[Content]
                                      ,[Image]
                                      ,[Level], Level.Name AS LevelName
                                      ,Question.SubjectCode, Subject.SubjectName
                                      ,[Type], Type.Name AS TypeName
                                  FROM [Question] JOIN Type ON Question.Type=Type.Id
		                                JOIN Level ON Question.Level=Level.Id
		                                JOIN Subject ON Question.SubjectCode=Subject.SubjectCode
                                  WHERE Question.Id = @questionId";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_question, connection);
                command.Parameters.AddWithValue("@questionId", questionId);

                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Question()
                    {
                        Id = questionId,
                        Content = reader.GetString("Content"),
                        Level = new Level()
                        {
                            Id = reader.GetInt16("Level"),
                            Name = reader.GetString("LevelName"),
                        },
                        Type = new Type()
                        {
                            Name = reader.GetString("TypeName"),
                            Id = reader.GetInt16("Type"),
                        },
                        Subject = new Subject()
                        {
                            SubjectCode = reader.GetString("SubjectCode"),
                            SubjectName = reader.GetString("SubjectName")
                        }
                    };
                }

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                connection.Close();
            }
            return null;
        }

        public Question GetRandomQuestionWithLevel(int levelId, string subjectCode)
        {
            string select_random_question = @"SELECT TOP 1 Question.[Id]
                                              ,[Content]
                                              ,[Image]
                                              ,[Level], Level.Name AS LevelName
                                              ,Question.SubjectCode, Subject.SubjectName
                                              ,[Type], Type.Name AS TypeName
                                          FROM [Question] JOIN Type ON Question.Type=Type.Id
		                                        JOIN Level ON Question.Level=Level.Id
		                                        JOIN Subject ON Question.SubjectCode=Subject.SubjectCode
                                          WHERE Question.Level=@Level AND Question.SubjectCode=@Subject
                                          ORDER BY NEWID()";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(select_random_question, connection);
                command.Parameters.AddWithValue("@Level", levelId);
                command.Parameters.AddWithValue("@Subject", subjectCode);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Question()
                    {
                        Id = reader.GetInt32("Id"),
                        Content = reader.GetString("Content"),
                        Level = new Level() {
                            Id = reader.GetInt16("Level"),
                            Name = reader.GetString("LevelName"),
                        },
                        Type = new Type() {
                            Name = reader.GetString("TypeName"),
                            Id = reader.GetInt16("Type"),
                        },
                        Subject = new Subject()
                        {
                            SubjectCode = reader.GetString("SubjectCode"),
                            SubjectName = reader.GetString("SubjectName")
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { connection.Close(); }
            return null;
        }

        public List<QuestionTest> GetQuestionByTests(int testID)
        {
            List<QuestionTest> result = new List<QuestionTest>();
            string sql_select_question = @"SELECT [QuestionId], Question.Content, Level.Name AS LevelName
                                        , Type.Name AS TypeName
                                  FROM [Question_Test] INNER JOIN Question ON Question.Id=Question_Test.QuestionId
	                                INNER JOIN Type ON Question.Type=Type.Id
	                                INNER JOIN LEVEL ON Question.Level=Level.Id
	                                WHERE TestId=@testId";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_question, connection);
                command.Parameters.AddWithValue("testId", testID);
                connection.Open();
                reader = command.ExecuteReader();
                Test test = null;
                while (reader.Read())
                {
                    if(test == null)
                    {
                        test = new Test()
                        {
                            Id = testID,
                        };
                    }
                    Question question = new Question()
                    {
                        Id = reader.GetInt32("QuestionId"),
                        Content = reader.GetString("Content"),
                        Level = new Level()
                        {
                            Name = reader.GetString("LevelName"),
                        },
                        Type = new Type()
                        {
                            Name = reader.GetString("TypeName"),
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
