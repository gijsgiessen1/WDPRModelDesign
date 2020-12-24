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
        public DateTime TimeStamp { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Coordinates { get; set; }
        public ICollection<Vote> Likes { get; set; }
        public ICollection<Flag> Flags { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
