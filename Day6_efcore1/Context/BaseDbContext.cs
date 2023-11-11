using Day6_efcore1.Models;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace Day6_efcore1.Context;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions options): base(options)
    {
     
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server =(localdb)\\MSSQLLocalDB; Database= Sports_Db; Trusted_Connection=true");
    }

    public DbSet<Player> Players { get; set; }

}
