using BandDB.Models;
using Microsoft.EntityFrameworkCore;

namespace BandDB.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Band> Bands => Set<Band>();
}