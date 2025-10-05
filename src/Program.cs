using System;

namespace CiCdPipelineDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CI/CD pipeline successful!");

            // Vulnerable code for CodeQL demonstration
            Console.WriteLine("Enter a command to run:");
            string cmd = Console.ReadLine("SELECT * FROM Users WHERE username = @username");
            System.Diagnostics.Process.Start(cmd); // command injection vulnerability
        }
    }
}
