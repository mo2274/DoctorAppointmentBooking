namespace DoctorAppointmentManagement.Core.Dto;

public class AppointmentDto
{
    public Guid Id { get; set; }
    public Guid PatientId { get; set; }
    public DateTime ReservedAt { get; set; }
    public string PatientName { get; set; }
}