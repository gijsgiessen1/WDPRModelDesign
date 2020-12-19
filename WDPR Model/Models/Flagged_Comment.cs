using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class Flagged_Comment
    {
        public int FlagId { get; set; }
        public Flag Flag { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
