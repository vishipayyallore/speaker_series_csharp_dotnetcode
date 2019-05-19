using System;
using VS2019.Enhanced.Scrollbar.Demo.Models;
using static System.Console;

namespace VS2019.Enhanced.Scrollbar.Demo
{

    class Program
    {

        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Blue;

            WriteLine("Hello World!");

            WriteLine("\n\nPress any key ...");
            ReadLine();
        }

    }


    public static class ExtensionMethods
    {

        public static (int value, bool parsed) ParseToInteger(this string input)
        {
            var returnValue = (value: 0, parsed: false);

            returnValue.parsed = int.TryParse(input, out returnValue.value);

            return returnValue;
        }

        public static void Deconstruct(this Manager manager, out string id, out string name)
        {
            id = manager.Id;
            name = manager.Name;
        }

        public static void Deconstruct(this Employee employee, out string id, out string name)
        {
            id = employee.Id;
            name = employee.Name;
        }

    }

}
