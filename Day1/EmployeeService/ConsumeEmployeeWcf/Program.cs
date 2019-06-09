using ConsumeEmployeeWcf.ServiceReference1;
using System.Data;
using static System.Console;

namespace ConsumeEmployeeWcf
{
    class Program
    {
        static void Main(string[] args)
        {

            Service1Client service1Client = new Service1Client();
            var employees = service1Client.GetAllEmployees();

            foreach(DataRow dataRow in employees.EmployeesTable.Rows)
            {
                WriteLine($"Name: {dataRow["Name"]}, Gender: {dataRow["Gender"]}");
            }

            WriteLine("\n\nPress any key ....");
            ReadKey();

        }
    }
}
