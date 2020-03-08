using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sınav2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual User User { get; set; }
    }
}
