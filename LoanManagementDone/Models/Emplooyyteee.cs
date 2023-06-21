using System;
using System.Collections.Generic;

#nullable disable

namespace LoanManagementDone.Models
{
    public partial class Emplooyyteee
    {
        public int EmpId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int? DId { get; set; }

        public virtual Departtmment DIdNavigation { get; set; }
    }
}
