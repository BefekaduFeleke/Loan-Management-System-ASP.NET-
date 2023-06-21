using System;
using System.Collections.Generic;

#nullable disable

namespace LoanManagementDone.Models
{
    public partial class LoanType
    {
        public LoanType()
        {
            LoanApplications = new HashSet<LoanApplication>();
        }

        public int LoanTypeId { get; set; }
        public decimal? MinimunAmount { get; set; }
        public decimal? MaximumAmount { get; set; }
        public string LoanName { get; set; }
        public string LoanDuration { get; set; }
        public decimal? ServiceCharge { get; set; }
        public string LoanDescription { get; set; }

        public virtual ICollection<LoanApplication> LoanApplications { get; set; }
    }
}
