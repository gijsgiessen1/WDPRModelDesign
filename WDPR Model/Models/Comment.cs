﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }
        public User User { get; set; }
        public Report Report { get; set; }
      
    }
}
