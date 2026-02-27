using System;
using System.ComponentModel.DataAnnotations;

namespace DMS.DAL.Entities
{
    public class Person
    {

        // Primary Key
        public long Id { get; set; }

        // Identity Information
        [Required]
        [StringLength(100)]
        public string FullNames { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Range(0, 120)]
        public int Age { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [StringLength(20)]
        public string IdNumber { get; set; }

        [StringLength(10)]
        public string Gender { get; set; } // could be enum in practice

        // Contact Information
        [Phone]
        public string PhoneNumber { get; set; }

        // Next of Kin
        [StringLength(100)]
        public string NextOfKinName { get; set; }

        [Phone]
        public string NextOfKinPhoneNumber { get; set; }

        // Workplace Information
        [StringLength(200)]
        public string WorkPlaceName { get; set; }

        [Phone]
        public string WorkPlacePhoneNumber { get; set; }

        public long CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}