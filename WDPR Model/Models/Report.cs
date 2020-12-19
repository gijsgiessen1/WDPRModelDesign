using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public ICollection<User_Report> User_Reports { get; set; }
        public ICollection<Flagged_Report> Flagged_Reports { get; set; }
        public ICollection<Like> Likes { get; set; }
    }
}
