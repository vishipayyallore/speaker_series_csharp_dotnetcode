using System;
using VS2019.Enhanced.Scrollbar.Demo.Demos;
using VS2019.Enhanced.Scrollbar.Demo.Helper;
using VS2019.Enhanced.Scrollbar.Demo.Models;
using static System.Console;

namespace VS2019.Enhanced.Scrollbar.Demo
{

    class Program
    {

        static void Main(string[] args)
        {

            int Age = 10;

            var demoHelper = new DemoHelper();

            demoHelper
                .ShowDemoOf(new ExtensionMethodsDemo(), ConsoleColor.Blue)
                .ShowDemoOf(new PatternMatchingDemo(), ConsoleColor.Yellow);

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
