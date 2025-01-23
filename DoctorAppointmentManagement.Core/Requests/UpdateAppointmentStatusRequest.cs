using DoctorAppointmentManagement.Core.Enums;

namespace DoctorAppointmentManagement.Core.Requests;

public class UpdateAppointmentStatusRequest
{
    public AppointmentStatus Status { get; set; }
}