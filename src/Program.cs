using System;
using System.Data.SqlClient;

namespace CiCdPipelineDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CI/CD pipeline successful!");

            // BAD: Vulnerable SQL query (CodeQL will flag this)
            string userInput = "1 OR 1=1";
            string query = "SELECT * FROM Users WHERE Id = '" + userInput + "'";

            using (var connection = new SqlConnection("Server=.;Database=Test;Trusted_Connection=True;"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteReader();
            }
        }
    }
}