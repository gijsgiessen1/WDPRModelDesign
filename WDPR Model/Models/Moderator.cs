using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class Moderator : User
    {
        public ICollection<Flag> Assigned_Flags { get; set; }
    }
}
