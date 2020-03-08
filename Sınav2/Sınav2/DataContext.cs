using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sınav2
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)

        {

        }
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Order> Orders { get; set; }
        public DbSet<Models.Address> Addresses { get; set; }
        public DbSet<Models.Product> Products { get; set; }
    }
}
