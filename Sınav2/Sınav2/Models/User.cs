using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sınav2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        
    }
}
