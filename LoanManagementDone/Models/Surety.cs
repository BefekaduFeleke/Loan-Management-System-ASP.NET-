using System;
using System.Collections.Generic;

#nullable disable

namespace LoanManagementDone.Models
{
    public partial class Surety
    {
        public Surety()
        {
            Customers = new HashSet<Customer>();
        }

        public int SuretyId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumberOne { get; set; }
        public string PhoneNumberTwo { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string IdType { get; set; }
        public string IdNumber { get; set; }
        public DateTime IdIssuedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Income { get; set; }
        public byte[] IncomeProofPhoto { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
