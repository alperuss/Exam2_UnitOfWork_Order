using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sınav2.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IAddressRepository AddressRepository { get; set; }
        IUserRepository UserRepository { get; set; }
        IOrderRepository OrderRepository { get; set; }
        IProductRepository ProductRepository { get; set; }
        int Complete();
    }
}
