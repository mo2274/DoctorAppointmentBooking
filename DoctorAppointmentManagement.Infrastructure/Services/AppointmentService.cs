using AppointmentBooking.Shared;
using DoctorAppointmentManagement.Core.Contracts.Infrastructure;
using DoctorAppointmentManagement.Core.Dto;

namespace DoctorAppointmentManagement.Infrastructure.Services;

public class AppointmentService : IAppointmentService
{
    private readonly IAppointmentBookingModuleApi _appointmentBookingModuleApi;

    public AppointmentService(IAppointmentBookingModuleApi appointmentBookingModuleApi)
    {
        _appointmentBookingModuleApi = appointmentBookingModuleApi;
    }

    public async Task<List<AppointmentDto>> GetUpcomingAppointment(int page, int pageSize)
    {
        var appointment = await _appointmentBookingModuleApi.GetUpcomingAppointments(page, pageSize);

        return appointment.Select(a => new AppointmentDto()
        {
            Id = a.Id,
            PatientId = a.PatientId,
            PatientName = a.PatientName,
            ReservedAt = a.ReservedAt
        }).ToList();
    }
}