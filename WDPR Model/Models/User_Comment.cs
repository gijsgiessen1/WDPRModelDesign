using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WDPR_Model.Models
{
    public class User_Comment
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
       
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
    }
}
