using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace College.DAL.Entities
{
    public class Student
    {
        [Key]
        public Guid StudentId { get; set; }

        public string Name { get; set; }

        public string RollNumber { get; set; }

        [ForeignKey("ProfessorId")]
        public Professor Professor { get; set; }

        public Guid ProfessorId { get; set; }

        public decimal Fees { get; set; }
    }

}
