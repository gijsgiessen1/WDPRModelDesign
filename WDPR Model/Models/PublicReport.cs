using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class PublicReport : Report
    {
        public User User { get; set; }
        public PublicReportCategory publicReportCategory { get; set; }
    }
}
