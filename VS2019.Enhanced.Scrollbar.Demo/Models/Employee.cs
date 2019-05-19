using System.Collections.Generic;

namespace VS2019.Enhanced.Scrollbar.Demo.Models
{

    public class Employee
    {
        public Employee()
        {
            TaskCodes = new List<int>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public List<int> TaskCodes { get; set; }

    }

}
