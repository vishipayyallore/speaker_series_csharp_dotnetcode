using System;

namespace College.Services.Entities
{
    public class Professor
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Doj { get; set; }

        public string Teaches { get; set; }

        public decimal Salary { get; set; }

        public bool IsPhd { get; set; }

    }

}
