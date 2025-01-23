namespace AppointmentBooking.Shared.Dtos;

public class UpcomingAppointmentDto
{
    public Guid Id { get; set; }
    public Guid PatientId { get; set; }
    public DateTime ReservedAt { get; set; }
    public string PatientName { get; set; }
}