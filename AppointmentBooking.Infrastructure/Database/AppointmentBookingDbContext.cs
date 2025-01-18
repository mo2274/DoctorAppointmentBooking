using System.Reflection;
using AppointmentBooking.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppointmentBooking.Infrastructure.Database;

public class AppointmentBookingDbContext : DbContext
{
    public AppointmentBookingDbContext(DbContextOptions<AppointmentBookingDbContext> options) : base(options)
    {
    }

    public DbSet<AppointmentEntity> Appointments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("AppointmentBookings");

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}