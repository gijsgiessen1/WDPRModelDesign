using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class FlagCategory
    {
        public int Id { get; set; }

        public string Categoryname { get; set; }
        public string FlagType { get; set; }
        public ICollection<Flag> Flags { get; set; }
    }
}
