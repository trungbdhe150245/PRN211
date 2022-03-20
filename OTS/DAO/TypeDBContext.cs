﻿using Microsoft.Data.SqlClient;
using OTS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS.DAO
{
    public class TypeDBContext : DBContext
    {

        public Models.Type GetTypeById(short id)
        {
            List<Models.Type> types = GetTypes();
            foreach (var t in types)
            {
                if(t.Id == id)
                {
                    return t;
                }
            }

            return null;
        }
        public List<Models.Type> GetTypes()
        {
            List<Models.Type> types = new List<Models.Type>();
            string getType = "SELECT [Id],[Name] FROM [Type]";

            try
            {
                connection = new SqlConnection(GetConnectionString());
                command = new SqlCommand(getType, connection);

                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Models.Type t = new Models.Type()
                    {
                        Id = reader.GetInt16("Id"),
                        Name = reader.GetString("Name")
                    };
                    types.Add(t);
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

            return types;
        }
    }
}
