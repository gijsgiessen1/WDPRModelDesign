using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class Vote
    {
        public int ReportId { get; set; }
      public Report Report { get; set; }
        public int UserId { get; set; }
      public User User { get; set; }
    }
}
