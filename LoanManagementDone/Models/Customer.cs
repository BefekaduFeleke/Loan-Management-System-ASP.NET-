using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


#nullable disable

namespace LoanManagementDone.Models
{
    public partial class Customer
    {
        public Customer()
        {
            LoanApplications = new HashSet<LoanApplication>();
        }


        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Customer's first name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Customer's middle name is required")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Customer's last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Customer's date of birth is required")]
        public DateTime? DateOfBirth { get; set; }
        [Required(ErrorMessage = "Customer's gender is required")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "You should at least enter one phone number")]
        [MaxLength(20), MinLength(10)]
        public string PhoneNumberOne { get; set; }
        [MaxLength(20), MinLength(10)]
        public string PhoneNumberTwo { get; set; }
        [Required(ErrorMessage = "Customer's email is required")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Customer's occupation is required")]
        public string Occupation { get; set; }
        public string CustomerStatus { get; set; }

        public byte[] ProfilePicture { get; set; }
        [Required(ErrorMessage = "Customer's Id details are required")]
        public string IdType { get; set; }
        [Required(ErrorMessage = "Customer's Id details are required")]
        public string IdNumber { get; set; }
        [Required(ErrorMessage = "Customer's Id details are required")]
        public DateTime? IdIssuedDate { get; set; }
        [Required(ErrorMessage = "Customer's Id details are required")]
        public DateTime? ExpiryDate { get; set; }
        [Required(ErrorMessage = "Customer's income is required")]
        public decimal? Income { get; set; }
        public byte[] IncomeProofPhoto { get; set; }
        public decimal? Rating { get; set; } = 5;
        public string Username { get; set; }
        public string Password { get; set; }
        public int? SuretyId { get; set; }

        public virtual Surety Surety { get; set; }
        public virtual ICollection<LoanApplication> LoanApplications { get; set; }
    }
}
