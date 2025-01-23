using DoctorAppointmentManagement.Core.Dto;

namespace DoctorAppointmentManagement.Core.Contracts.Infrastructure;

public interface IAppointmentService
{
    Task<List<AppointmentDto>> GetUpcomingAppointment(int page, int pageSize);
}