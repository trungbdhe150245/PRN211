﻿using Microsoft.Data.SqlClient;
using OTS.DAO;
using OTS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS.DAO
{
    internal class ClassDBContext : DBContext
    {
        public int DeleteClass(List<Class> Classes)
        {
            int rowAffects = 0;
            string parameters = "0";
            List<string> listParam = new List<string>();

            for (int i = 0; i < Classes.Count; i++)
            {
                listParam.Add("@ClassID" + i);
            }
            if (Classes.Count > 0)
                parameters = String.Join(", ", listParam);

            string sql_delete_classes = @$"DELETE FROM [Class]
                                        WHERE Id IN ({parameters})";

            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_delete_classes, connection);
                for (int i = 0; i < Classes.Count; i++)
                {
                    command.Parameters.AddWithValue(listParam[i], Classes[i].Id);
                }
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
        public int UpdateClass(Class targetClass)
        {
            int rowAffects = 0;
            string sql_update_class = @"UPDATE [Class]
                                       SET [Name] = @name
                                     WHERE Id = @id";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_update_class, connection);
                command.Parameters.AddWithValue("@name", targetClass.Name);
                command.Parameters.AddWithValue("@id", targetClass.Id);

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
        public bool IsClassExist(string className)
        {
            bool isExist = false;

            string sql_select_class = @"SELECT [Id]
                                      ,[Name]
                                  FROM [Class] WHERE NAME = @Name";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_class, connection);
                command.Parameters.AddWithValue("@Name", className);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isExist = true;
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

            return isExist;
        }

        public List<Class> getClasses(string querySearch, string searchOption)
        {
            List<Class> classes = new List<Class>();
            string whereQuery = "";
            switch (searchOption)
            {
                case "name":
                    whereQuery = " [Name] Like '%' + @name + '%'";
                    break;
                case "id":
                    whereQuery = " [Id] = @id";
                    break;
                default: whereQuery = " (1=1) "; break;
            }

            string sql_select_class = @$"SELECT [Id]
                                      ,[Name]
                                  FROM [Class]
                                  WHERE {whereQuery}";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(sql_select_class, connection);
                switch (searchOption)
                {
                    case "name":
                        command.Parameters.AddWithValue("@name", querySearch);
                        break;
                    case "id":
                        command.Parameters.AddWithValue("@id", querySearch);
                        break;
                }

                connection.Open();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Class cls = new Class()
                    {
                        Name = reader.GetString("Name"),
                        Id = reader.GetInt32("Id"),
                    };
                    classes.Add(cls);

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

            return classes;
        }

        public int AddClass(Class newClass)
        {
            int rowAffects = 0;
            string sql_insert_class = @"INSERT INTO [Class]
                                           ([Name])
                                     VALUES (@className)";
            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(@sql_insert_class, connection);
                command.Parameters.AddWithValue("@className", newClass.Name);
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
    }

}
