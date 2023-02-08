using crud_aspnet.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace crud_aspnet.Data
{
    public class MVCDEMODbContext : DbContext
    {
        public MVCDEMODbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }



    }
}
