using AppointmentBooking.Domain.Models;
using AppointmentBooking.Infrastructure.Database.Entities;

namespace AppointmentBooking.Infrastructure.Database.Repositories;

public class AppointmentRepository : IAppointmentRepository
{
    private readonly AppointmentBookingDbContext _dbContext;

    public AppointmentRepository(AppointmentBookingDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task Add(Appointment appointment, CancellationToken cancellationToken = default)
    {
        await _dbContext.Appointments.AddAsync(AppointmentEntity.FromDomainModel(appointment), cancellationToken);
        
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}