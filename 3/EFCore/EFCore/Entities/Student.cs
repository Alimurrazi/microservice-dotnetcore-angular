using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    public class Student
    {
        public Guid StudentId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage="Length must be less than 50 characters")]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
