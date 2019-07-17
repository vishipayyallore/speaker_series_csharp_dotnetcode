using System;
using System.ComponentModel.DataAnnotations;

namespace College.Common.Dtos
{

    public class StudentForAddOrUpdate
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string RollNumber { get; set; }

        [Required]
        public Guid ProfessorId { get; set; }

        [Required]
        // [Range(typeof(bool), "false", "true", ErrorMessage = "The field Is Active must be checked.")]
        public decimal Salary { get; set; }
    }

}
