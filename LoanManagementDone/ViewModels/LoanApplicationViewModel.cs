using LoanManagementDone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementDone.ViewModels
{
    public class LoanApplicationViewModel
    {
        public LoanType LoanType { get; set; }
        public LoanApplication LoanApplication { get; set; }
    }
}
