using System.Reflection;
using DoctorAvailability.Data.Enitities;
using Microsoft.EntityFrameworkCore;

namespace DoctorAvailability.Data;

public class DoctorAvailabilityDbContext : DbContext
{
    public DoctorAvailabilityDbContext(DbContextOptions<DoctorAvailabilityDbContext> options) : base(options)
    { }

    public DbSet<Slot> Slots { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("DoctorAvailabilities");

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}