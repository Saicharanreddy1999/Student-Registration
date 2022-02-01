using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegistration.Models
{
    public class RegDetails
    {
        [Required]
        [MaxLength(10)]
        [Display(Name ="Student Id")]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string College { get; set; }
        [Required]
        public string Course { get; set; }
    }
}