using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sınav2.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressName { get; set; }
        public virtual Order Order { get; set; }
        public virtual User User { get; set; }
    }
}
