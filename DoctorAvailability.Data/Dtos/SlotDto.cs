namespace DoctorAvailability.Data.Dtos;

public class SlotDto
{
    public DateTime Time { get; set; }
    public decimal Cost { get; set; }
    public bool IsReserved { get; set; }
}