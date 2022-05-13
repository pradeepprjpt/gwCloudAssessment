using System;
using System.ComponentModel.DataAnnotations;

namespace gwCloudAssessment.Context
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(500)]
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        [Required, RegularExpression(@"(\d{3})[\.\s]?(\d{3})[\.\s]?(\d{3})[-\s]?(\d{2})", ErrorMessage = "Enter valid CPF/RG number.")]
        public string CPF_RG { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public bool IsActive { get; set; }
    }
}
