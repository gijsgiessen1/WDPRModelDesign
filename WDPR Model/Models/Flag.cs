using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class Flag
    {
        public int Id { get; set; }
        public string Urgency { get; set; }
        public string Category { get; set; }
        public bool Is_Dealth_With { get; set; }
        public ICollection<Flagged_Comment> Flagged_Comments { get; set; }
        public ICollection<Flagged_Report> Flagged_Reports { get; set; }

    }
}
