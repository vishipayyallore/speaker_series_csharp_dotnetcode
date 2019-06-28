using College.Common.Entities;
using System;
using System.Collections.Generic;

namespace College.Common.Dtos
{
    public class ProfessorForViewDto
    {
        public Guid ProfessorId { get; set; }

        public string Name { get; set; }

        public DateTime Doj { get; set; }

        public string Teaches { get; set; }

        public decimal Salary { get; set; }

        public bool IsPhd { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }

}
