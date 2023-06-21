using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace LoanManagementDone.Models
{
    public partial class LoanApplication
    {


        public int LoanApplicationId { get; set; }
        [Required(ErrorMessage = "Loan Control Number is required")]
        public string LoanControlNumber { get; set; }
        public decimal LoanAmount { get; set; }
        //public decimal? AmountToBePaid { get; set; }
        public decimal? TotalAmount { get; set; }
        [Required(ErrorMessage = "Purpose of this loan is required")]
        public string Purpose { get; set; }
        public DateTime LoanApplicationSubmissionDate { get; set; }
        public DateTime? LoanApplicationApprovedDate { get; set; }
        public string LoanStatus { get; set; } = "Submitted";
        public string? Remarks { get; set; }
        public int? CustomerId { get; set; }
        public string? PaymentStatus { get; set; }
        public int? LoanTypeId { get; set; }
        public DateTime? PaymentDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual LoanType LoanType { get; set; }

    }
}
