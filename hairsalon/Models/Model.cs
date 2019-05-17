using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HairSalon.Models
{

  public class SalonContext : DbContext
  {
    public DbSet<Client> client { get; set; }
    public DbSet<Stylist> stylist { get; set; }
    public DbSet<Scissors> scissors { get; set; }
    public DbSet<Join> join { get; set; }
    public DbSet<Suffix> suffix { get; set; }
    public DbSet<Prefix> prefix { get; set; }
    public DbSet<Specialty> specialty { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=jared_farkas;user=root;password=root;port=8889;");
    }
  }
}
