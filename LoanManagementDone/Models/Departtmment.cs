using System;
using System.Collections.Generic;

#nullable disable

namespace LoanManagementDone.Models
{
    public partial class Departtmment
    {
        public Departtmment()
        {
            Emplooyyteees = new HashSet<Emplooyyteee>();
        }

        public int DepId { get; set; }
        public string DepName { get; set; }
        public string City { get; set; }

        public virtual ICollection<Emplooyyteee> Emplooyyteees { get; set; }
    }
}
