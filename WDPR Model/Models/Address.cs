using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WDPR_Model.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string Address_line { get; set; }

        public string Postal_code { get; set; }

        public string City { get; set; }

        public ICollection<User_Address> User_Addresses { get; set; }
    }
}
