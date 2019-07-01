using System;
using System.ComponentModel.DataAnnotations;

namespace Collage.Api.Entities
{

    public class Student
    {
        [Key]
        public Guid StudentId { get; set; }

        public string Name { get; set; }

        public string RollNumber { get; set; }

        public Guid ProfessorId { get; set; }

        public decimal Fees { get; set; }
    }

}
