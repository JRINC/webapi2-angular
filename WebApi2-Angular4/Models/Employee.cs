using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi2_Angular4.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
    }
}