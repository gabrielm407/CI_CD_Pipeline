using System;

namespace CiCdPipelineDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CI/CD pipeline successful!");

            // Check for CI environment variable
            if (Environment.GetEnvironmentVariable("CI") == "true")
            {
                Console.WriteLine("Skipping database call in CI/CD pipeline.");
                return;
            }

            // BAD: Vulnerable SQL query (CodeQL will flag this)
            string userInput = "1 OR 1=1";
            string query = "SELECT * FROM Users WHERE Id = '" + userInput + "'";

            using (var connection = new System.Data.SqlClient.SqlConnection("Server=.;Database=Test;Trusted_Connection=True;"))
            {
                var command = new System.Data.SqlClient.SqlCommand(query, connection);
                connection.Open();
                command.ExecuteReader();
            }
        }
    }
}