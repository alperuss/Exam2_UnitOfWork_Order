using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sınav2.Interfaces;

namespace Sınav2.Services
{
    public class UnitOfWork:Interfaces.IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            UserRepository = new Services.UserRepository(_dataContext);
            AddressRepository = new Services.AddressRepository(_dataContext);
            OrderRepository = new Services.OrderRepository(_dataContext);
            ProductRepository = new Services.ProductRepository(_dataContext);

        }

        public IAddressRepository AddressRepository { get; set; }
        public IUserRepository UserRepository { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public IProductRepository ProductRepository { get ; set ; }

        public int Complete()
        {
            return _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
