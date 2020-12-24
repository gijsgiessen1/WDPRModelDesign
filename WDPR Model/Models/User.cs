using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string ProfilePicture { get; set; }
        public ICollection<Vote> Likes { get; set; }
        public ICollection<Flag> Flags { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<PublicReport> Reports { get; set; }
        public Role Role { get; set; }
        public Address Address { get; set; }
    }
}
