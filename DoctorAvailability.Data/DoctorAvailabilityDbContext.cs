using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace DoctorAvailability.Data;

internal class DoctorAvailabilityDbContext : DbContext
{
    public DoctorAvailabilityDbContext(DbContextOptions<DoctorAvailabilityDbContext> options) : base(options)
    { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("DoctorAvailabilities");

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}