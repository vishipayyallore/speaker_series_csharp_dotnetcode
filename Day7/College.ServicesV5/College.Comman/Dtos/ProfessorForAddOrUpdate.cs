using System;

namespace College.Common.Dtos
{

    public class ProfessorForAddOrUpdate
    {
        public string Name { get; set; }

        public DateTime Doj { get; set; }

        public string Teaches { get; set; }

        public decimal Salary { get; set; }

        public bool IsPhd { get; set; }
    }

}
