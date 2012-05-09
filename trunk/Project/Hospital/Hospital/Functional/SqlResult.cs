using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Functional
{
    public static class SqlResult
    {
        //Get ConnectionString in app.config
        private static string sqlConnectString = ConfigurationManager.ConnectionStrings["eHospital-Binh"].ConnectionString;

        //Execute insert, update, delete command without parameters
        public static int ExecuteNonQuery(string commandString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnectString))
                {
                    SqlCommand command = new SqlCommand(commandString, connection);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        //Execute insert, update, delete command with parameters
        public static int ExecuteNonQuery(string commandString, SqlParameter[] sqlParametes)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnectString))
                {
                    SqlCommand command = new SqlCommand(commandString, connection);
                    command.Parameters.AddRange(sqlParametes);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        //Execute select without parameters
        public static DataTable ExecuteQuery(string commandString)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commandString, sqlConnectString);                
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        //Execute select with parameters
        public static DataTable ExecuteQuery(string commandString, SqlParameter[] sqlParametes)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commandString, sqlConnectString);
                sqlDataAdapter.SelectCommand.Parameters.AddRange(sqlParametes);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }
    }
}
