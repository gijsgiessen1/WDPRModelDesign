using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public ICollection<User_Comment> User_Comments { get; set; }
        public ICollection<Flagged_Comment> Flagged_Comments { get; set; }
    }
}
