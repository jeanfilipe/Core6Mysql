using Microsoft.EntityFrameworkCore;
using Mysql.Models;

namespace Mysql.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cnae> Cnaes { get; set; }

    }
}
