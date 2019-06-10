using System;

namespace EmployeesWebService.Data
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public float Salary { get; set; }

    }
}