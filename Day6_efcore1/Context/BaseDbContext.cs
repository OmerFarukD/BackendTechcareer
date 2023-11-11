using Day6_efcore1.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Player> Players { get; set; }
    public DbSet<Team> Teams { get; set; }

    public DbSet<Outfit> Outfits { get; set; }

    public DbSet<Branch> Branches { get; set; }


}
