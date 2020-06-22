using  System;
using System.Data;
using Npgsql;

namespace Arkanoid_Game
{
    public class ConnectionDB
    {
        private static string host = "ec2-52-202-146-43.compute-1.amazonaws.com",
            database = "d1vvlnhj9tf6fo",
            userId = "oxigskvmxkueje",
            password = "b2e34c8a48df91d3a8e153866136820ed7a78f7f6e3ef744a50a434c41980a29";

        private static string sConnection =
            $"Server={host};Port=5432;User Id= {userId};Password={password};Database={database};" +
            $"sslmode=Require;Trust Server Certificate=true";

        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();

            connection.Open();
            
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            
            connection.Close();

            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string act)
        {
            
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }  
    }
}