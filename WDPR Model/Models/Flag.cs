using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class Flag
    {
        public int Id { get; set; }
        
        public string Note { get; set; }
        public bool IsDealtWith { get; set; }
        public FlagCategory FlagCategory { get; set; }
        public User User { get; set; }
        public Report Report { get; set; }

    }
}
