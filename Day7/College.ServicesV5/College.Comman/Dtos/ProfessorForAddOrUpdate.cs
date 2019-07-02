using System;
using System.ComponentModel.DataAnnotations;

namespace College.Common.Dtos
{

    public class ProfessorForAddOrUpdate
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime Doj { get; set; }

        public string Teaches { get; set; }

        public decimal Salary { get; set; }

        public bool IsPhd { get; set; }
    }

}
