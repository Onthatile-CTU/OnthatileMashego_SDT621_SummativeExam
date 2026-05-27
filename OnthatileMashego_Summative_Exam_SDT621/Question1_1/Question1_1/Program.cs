using System;

namespace Question1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to the Structure of a C# Program Demo!");

            // Prompt user for their name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Display personalised greeting
            Console.WriteLine("Hello " + name + "!");

            Console.WriteLine();
            Console.WriteLine("Program Structure Demonstrated:");
            Console.WriteLine("1. using System: imports functionality");
            Console.WriteLine("2. namespace: organizes code");
            Console.WriteLine("3. class Program: container for code");
            Console.WriteLine("4. Main(): entry point of program");
            Console.WriteLine("5. Comments: explain logic and documentation");

            Console.WriteLine();
            Console.WriteLine("Program executed successfully!");
        }
    }
}
