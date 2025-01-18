namespace AppointmentBooking.Application.Commands;

public record CreateAppointment
{
    public Guid SlotId { get; set; }
    public Guid PatientId { get; set; } 
    public string PatientName { get; set; }
    public DateTime ReservedAt { get; set; }
}