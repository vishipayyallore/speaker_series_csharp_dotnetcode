using System;

namespace FirstWebApi.Entities
{

    public class Employee
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public Decimal Salary { get; set; }
    }

}