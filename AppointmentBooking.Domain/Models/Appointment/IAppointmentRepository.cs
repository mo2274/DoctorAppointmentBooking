namespace AppointmentBooking.Domain.Models;

public interface IAppointmentRepository
{
    Task Add(Appointment appointment, CancellationToken cancellationToken = default);
}