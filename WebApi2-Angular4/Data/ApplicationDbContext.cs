using System.Data.Entity;
using WebApi2_Angular4.Models;

namespace WebApi2_Angular4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :
          base("ConnectionString")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<User> Users { get; set; }
    }
}