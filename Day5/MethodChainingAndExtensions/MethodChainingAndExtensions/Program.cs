using MethodChainingAndExtensions.ChainingDemo;
using MethodChainingAndExtensions.ExtensionMethodsDemo;
using System;
using System.Text;
using static System.Console;

namespace MethodChainingAndExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Yellow;

            StringBuilder personDetails = new StringBuilder(1024);
            personDetails
                .Append("Item 1")
                .Append("\nItem 2")
                .Append("\nItem 3");
            WriteLine(personDetails);

            // Method Chaining Sample 2
            var softwareDeveloper = new SoftwareDeveloper();
            WriteLine($"\n\n==================== Sample 2 Custom Class ====================");
            softwareDeveloper
                .GathersRequirements()
                .WritesCode()
                .WriteUnitTests()
                .DeploysCodeToProduction();
            WriteLine($"-------------------- Sample 2 Custom Class --------------------\n\n");


            WriteLine(softwareDeveloper.GetSoftwareDeveloper());

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
