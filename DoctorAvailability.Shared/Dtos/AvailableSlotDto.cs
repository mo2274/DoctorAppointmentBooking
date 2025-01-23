namespace DoctorAvailability.Shared.Dtos;

public class AvailableSlotDto
{
    public Guid Id { get; set; }
    public DateTime Time { get; set; }
    public decimal Cost { get; set; }
}