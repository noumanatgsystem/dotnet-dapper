using dapper.Entities;
using Microsoft.EntityFrameworkCore;

namespace dapper.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DapperDbModel> Dapper { get; set; }
    }
}
