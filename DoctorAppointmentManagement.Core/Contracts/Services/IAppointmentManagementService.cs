using DoctorAppointmentManagement.Core.Dto;
using DoctorAppointmentManagement.Core.Requests;

namespace DoctorAppointmentManagement.Core.Contracts.Services;

public interface IAppointmentManagementService
{
    Task<List<AppointmentDto>> GetUpcomingAppointments(int page, int pageSize);
    Task UpdateAppointmentStatus(Guid id, UpdateAppointmentStatusRequest request);
}