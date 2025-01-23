using AppointmentBooking.Shared.Dtos;

namespace AppointmentBooking.Shared;

public interface IAppointmentBookingModuleApi
{
    Task<List<UpcomingAppointmentDto>> GetUpcomingAppointments(int page, int pageSize);
}