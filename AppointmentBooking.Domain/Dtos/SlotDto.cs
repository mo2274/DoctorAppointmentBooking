namespace AppointmentBooking.Domain.Dtos;

public class SlotDto
{
    public Guid Id { get; set; }
    public DateTime Time { get; set; }
    public decimal Cost { get; set; }
}