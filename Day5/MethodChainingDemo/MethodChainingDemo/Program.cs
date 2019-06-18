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
            var softwareDeveloper = new SoftwareDeveloper();
            softwareDeveloper
                .GathersRequirements()
                .WritesCode()
                .WriteUnitTests()
                .DeploysCodeToProduction();
            WriteLine($"-------------------- Sample 2 Custom Class --------------------\n\n");

            WriteLine("Press any key ...");
            ReadKey();
        }
    }
}
