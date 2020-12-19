using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WDPR_Model.Models
{
    public class User_Report
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ReportId { get; set; }
        public Report Report { get; set; }

        [Column(TypeName="Date")]
        public DateTime Date { get; set; }
    }
}
