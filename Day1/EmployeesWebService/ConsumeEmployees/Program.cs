using System;
using static System.Console;

namespace ConsumeEmployees
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceReference1.AbcEmployeesSoapClient abcEmployeesSoapClient = new ServiceReference1.AbcEmployeesSoapClient("AbcEmployeesSoap");
            var employees = abcEmployeesSoapClient.GetAllEmployees();
            foreach (var employee in employees)
            {
                WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
            }

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
