using System;
using System.ComponentModel.DataAnnotations;

namespace College.Common.Dtos
{

    public class ProfessorForAddOrUpdate
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(typeof(DateTime), "1/2/2010", "3/4/2019",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime Doj { get; set; }

        [Required]
        public string Teaches { get; set; }

        [Required]
        [Range(typeof(decimal), "1000.00", "4000.00", ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public decimal Salary { get; set; }

        [Required]
        // [Range(typeof(bool), "false", "true", ErrorMessage = "The field Is Active must be checked.")]
        public bool IsPhd { get; set; }
    }

}
