﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sınav2.Services
{
    public class UserRepository:Repository<Models.User>,Interfaces.IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
