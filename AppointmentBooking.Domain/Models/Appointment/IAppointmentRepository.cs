using AppointmentBooking.Shared.Dtos;

namespace AppointmentBooking.Domain.Models;

public interface IAppointmentRepository
{
    Task Add(Appointment appointment, CancellationToken cancellationToken = default);
    Task<List<UpcomingAppointmentDto>> GetUpcomingAppointments(int page, int pageSize);
    Task<Appointment> GetAsync(Guid id);
    Task UpdateAsync(Appointment appointment, CancellationToken cancellationToken = default);
}