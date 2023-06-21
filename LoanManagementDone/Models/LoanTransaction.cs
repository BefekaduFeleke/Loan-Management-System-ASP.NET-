using System;
using System.Collections.Generic;

#nullable disable

namespace LoanManagementDone.Models
{
    public partial class LoanTransaction
    {
        public int LoanTransactionId { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime? LoanStartDate { get; set; }
        public DateTime? LoanPaymentDate { get; set; }
        public int? LoanApplicationId { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }
    }
}
