using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindCarGame
{
    class DatabaseConnector
    {
        private String _dbConnectionString;

        public DatabaseConnector(String dbConnectionString)
        {
            _dbConnectionString = dbConnectionString;
        }

        //DEFAULT METHODS
        public string ExecuteSqlCommandForSingleValue(string dbName, string sqlCommand)
        {
            string results = "";

            SqlConnection sqlConnection1 = new SqlConnection(_dbConnectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = sqlCommand;
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            try
            {
                sqlConnection1.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    results = reader[0].ToString();
                }
                sqlConnection1.Close();

                return results;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing SQL command: \n" + ex);
            }
            return "";
        }

        public bool ExecuteSqlCommandHasRows(string dbName, string sqlCommand)
        {
            bool results = false;
            SqlConnection sqlConnection1 = new SqlConnection(_dbConnectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = sqlCommand;
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            try
            {
                sqlConnection1.Open();
                reader = cmd.ExecuteReader();
                results = reader.HasRows;
                sqlConnection1.Close();
                return results;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting SQL command column count " + ex.Message);
            }
            return false;
        }
    }
}