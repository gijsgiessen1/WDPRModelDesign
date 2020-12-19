using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<User_Address> User_Addresses { get; set; }
        public ICollection<User_Report> User_Reports { get; set; }
        public ICollection<User_Comment> User_Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Flag> Flags { get; set; }
    }
}
