using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class Flagged_Report
    {
        public int FlagId { get; set; }
        public Flag Flag { get; set; }
        public int ReportId { get; set; }
        public Report Report { get; set; }
    }
}
