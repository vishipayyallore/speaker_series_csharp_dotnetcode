using MethodChainingDemo.ChainingDemo;
using MethodChainingDemo.ExtensionMethodsDemo;
using System;
using System.Text;
using static System.Console;

namespace MethodChainingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Blue;

            // Method Chaining Sample 1
            var stringBuilder = new StringBuilder(1024);
            var personDetails = stringBuilder
                                    .Append("Name: Shiva")
                                    .Append("\nAge: 25")
                                    .Append("\nSalary: 1234.56");

            WriteLine(personDetails);


            // Method Chaining Sample 2
            WriteLine($"\n\n==================== Sample 2 Custom Class ====================");
            SoftwareDeveloper softwareDeveloper = new SoftwareDeveloper();
            softwareDeveloper
                .GathersRequirements()
                .WritesCode()
                .WriteUnitTests()
                .DeploysCodeToProduction();
            WriteLine($"-------------------- Sample 2 Custom Class --------------------\n\n");


            // Extension Method Demo
            var number1 = "125";
            var (value, parsed) = number1.ParseToInteger();
            WriteLine($"{number1} was {parsed} and its value is {value}");

            number1 = "A125";
            (value, parsed) = number1.ParseToInteger();
            WriteLine($"{number1} was {parsed} and its value is {value}");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
