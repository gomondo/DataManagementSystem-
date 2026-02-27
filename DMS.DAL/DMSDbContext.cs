
using Microsoft.EntityFrameworkCore;

namespace DMS.DAL
{
    public class DMSDbContext :DbContext
    {


        public DbSet<Entities.Customer> Customers { get; set; }
        public DbSet<Entities.Person> People { get; set; }
        public DbSet<Entities.Company> Companies { get; set; }
        public DbSet<Entities.Address> Addresses { get; set; }
        public DMSDbContext(DbContextOptions<DMSDbContext> options) : base(options)
        {
        }
    }
}
