using System;
using System.IO;

namespace CiCdPipelineDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CI/CD pipeline successful!");

            // Vulnerable code for CodeQL demonstration: invalid command execution
            Console.WriteLine("Enter a filename to read:");
            string cmd = "calc.exe";

            try
            {
                System.Diagnostics.Process.Start(cmd); // command injection vulnerability
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }
}