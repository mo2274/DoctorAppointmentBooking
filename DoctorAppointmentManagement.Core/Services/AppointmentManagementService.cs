using DoctorAppointmentManagement.Core.Contracts.Infrastructure;
using DoctorAppointmentManagement.Core.Contracts.Services;
using DoctorAppointmentManagement.Core.Dto;

namespace DoctorAppointmentManagement.Core.Services;

public class AppointmentManagementService : IAppointmentManagementService
{
    private readonly IAppointmentService _appointmentService;

    public AppointmentManagementService(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }
    
    public async Task<List<AppointmentDto>> GetUpcomingAppointments(int page, int pageSize)
    {
        return await _appointmentService.GetUpcomingAppointment(page, pageSize);
    }
}