using AppointmentBooking.Domain.Models;
using AppointmentBooking.Shared;
using AppointmentBooking.Shared.Dtos;

namespace AppointmentBooking.Application.Services;

public class AppointmentBookingModuleApi : IAppointmentBookingModuleApi
{
    private readonly IAppointmentRepository _appointmentRepository;

    public AppointmentBookingModuleApi(IAppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }
    
    public async Task<List<UpcomingAppointmentDto>> GetUpcomingAppointments(int page, int pageSize)
    {
        return await _appointmentRepository.GetUpcomingAppointments(page, pageSize);
    }
}