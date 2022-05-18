using Microsoft.EntityFrameworkCore;
using WeatherStation.DataAccess.Entities;

namespace WeatherStation.DataAccess;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    { }

    public DbSet<WeatherStationEntity> Persons { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeatherStationEntity>(entity =>
        {
            entity.ToTable("WeatherStations");
            entity.HasKey(b => b.WeatherStationId);
            entity.Property(b => b.Name);
        });
    }
}