using ConsumeASMXWebService.ServiceReference1;
using static System.Console;

namespace ConsumeASMXWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            ABCServiceSoapClient abcEmployeesSoapClient = new ABCServiceSoapClient("ABCServiceSoap");
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
