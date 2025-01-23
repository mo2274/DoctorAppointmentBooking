using AppointmentBooking.Domain.Models;
using AppointmentBooking.Infrastructure.Database.Entities;
using AppointmentBooking.Shared.Dtos;
using Microsoft.EntityFrameworkCore;

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
        
        // TODO: Publish event
    }

    public async Task<List<UpcomingAppointmentDto>> GetUpcomingAppointments(int page, int pageSize)
    {
        return await _dbContext.Appointments
            .Where(a => a.ReservedAt.Date >= DateTime.UtcNow.Date)
            .Select(a => new UpcomingAppointmentDto()
            {
                Id = a.Id,
                ReservedAt = a.ReservedAt,
                PatientId = a.PatientId,
                PatientName = a.PatientName
            })
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}