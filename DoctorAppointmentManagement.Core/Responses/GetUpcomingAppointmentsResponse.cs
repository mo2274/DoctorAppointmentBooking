using DoctorAppointmentManagement.Core.Dto;

namespace DoctorAppointmentManagement.Core.Responses;

public class GetUpcomingAppointmentsResponse
{
    public List<AppointmentDto> Appointments { get; set; }
}