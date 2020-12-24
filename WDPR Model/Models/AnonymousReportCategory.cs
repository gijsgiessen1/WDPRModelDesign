using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class AnonymousReportCategory
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }
        public ICollection<AnonymousReport> AnonymousReports { get; set; }
        
    }
}
