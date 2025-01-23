using DoctorAppointmentManagement.Core.Dto;

namespace DoctorAppointmentManagement.Core.Contracts.Services;

public interface IAppointmentManagementService
{
    Task<List<AppointmentDto>> GetUpcomingAppointments(int page, int pageSize);
}