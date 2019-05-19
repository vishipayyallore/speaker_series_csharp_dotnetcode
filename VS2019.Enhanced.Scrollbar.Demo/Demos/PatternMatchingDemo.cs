using VS2019.Enhanced.Scrollbar.Demo.Interfaces;
using VS2019.Enhanced.Scrollbar.Demo.Models;
using static System.Console;

namespace VS2019.Enhanced.Scrollbar.Demo.Demos
{

    public class PatternMatchingDemo : IDataTypeDemo
    {
        public string Title => GetType().Name;

        public void ShowDemo()
        {
            var employee = new Employee { Id = "E101", Name = "Anil", TaskCodes = { 101, 102, 103, 104 } };
            var manager = new Manager { Id = "M101", Name = "Ashish", Repotees = { "Jagan", "Abhishek", "Swamy" } };

            DisplayInformation(employee);
            DisplayInformation(manager);
            DisplayInformation(null);

            DisplayInformationUsingSwitch(employee);
            DisplayInformationUsingSwitch(manager);
            DisplayInformationUsingSwitch(null);

            // Using Deconstruction
            var (id, name) = employee;
            WriteLine($"Employee Deconstruction Id= {id}, Name= {name} ");

            (id, name) = manager;
            WriteLine($"Manager Deconstruction Id= {id}, Name= {name} ");
        }

        // is expression pattern matching
        private void DisplayInformation(object person)
        {
            if (person is Employee employee)
            {
                WriteLine($"Id= {employee.Id}, Name= {employee.Name}, Task Codes= {string.Join<int>(", ", employee.TaskCodes)} ");
            }
            if (person is Manager manager)
            {
                WriteLine($"Id= {manager.Id}, Name= {manager.Name}, Repotees= {string.Join<string>(", ", manager.Repotees)} ");
            }
            if (person is null)
            {
                WriteLine($"Object {nameof(person)} is null");
            }
        }

        private void DisplayInformationUsingSwitch(object person)
        {
            switch (person)
            {
                case Employee employee:
                    WriteLine($"Id= {employee.Id}, Name= {employee.Name}, Task Codes= {string.Join<int>(", ", employee.TaskCodes)} ");
                    break;
                case Manager manager:
                    WriteLine($"Id= {manager.Id}, Name= {manager.Name}, Repotees= {string.Join<string>(", ", manager.Repotees)} ");
                    break;
                case null:
                    WriteLine($"Object {nameof(person)} is null");
                    break;
                default:
                    WriteLine($"Unable to determine the Object {nameof(person)}");
                    break;
            }
        }

    }

}
