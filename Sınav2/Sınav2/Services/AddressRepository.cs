using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sınav2.Services
{
    public class AddressRepository:Repository<Models.Address>,Interfaces.IAddressRepository
    {
        private readonly DataContext _dataContext;
        public AddressRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
