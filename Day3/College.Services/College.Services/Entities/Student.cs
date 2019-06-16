using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace College.Services.Entities
{

    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string RollNumber { get; set; }

        [ForeignKey("ProfessorId")]
        public Professor Professor { get; set; }

        public Guid ProfessorId { get; set; }

        public DateTime Dob { get; set; }

        public bool IsAthlete { get; set; }

        public decimal Fees { get; set; }
    }

}
