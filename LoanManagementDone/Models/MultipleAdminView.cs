using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementDone.Models
{
    public class MultipleAdminView
    {
        public LoanType LoanTypesAdminView { get; set; }
        public LoanApplication LoanApplicationAdminView { get; set; }
        public Customer CustomerAdminview { get; set; }

    }
}
