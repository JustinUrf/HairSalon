using Microsoft.EntityFrameworkCore;
namespace BestRestaurant.Models;

public class HairSalonContext : DbContext
{
  public DbSet<Stylist> Stylists { get; set; }
  public DbSet<Client> Clients { get; set; }

  public HairSalonContextContext(DbContextOptions options) : base(options) { }
}