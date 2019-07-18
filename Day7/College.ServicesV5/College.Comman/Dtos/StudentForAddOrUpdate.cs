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
        public decimal Fees { get; set; }
    }

}
