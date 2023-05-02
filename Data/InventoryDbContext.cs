
using Inventory_M.Models.users_management;
using Microsoft.EntityFrameworkCore;

namespace Inventory_M.Data
{
    public class InventoryDbContext :  DbContext
    {
        public InventoryDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<user> Users { get; set; }
        public DbSet<role> Roles { get; set; }

    }
}
