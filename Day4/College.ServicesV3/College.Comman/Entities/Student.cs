using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace College.Comman.Entities
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string RollNumber { get; set; }


        public DateTime Dob { get; set; }

        public bool IsAthlete { get; set; }

        public decimal Fees { get; set; }

        public Guid ProfessorId { get; set; }
    }

}
