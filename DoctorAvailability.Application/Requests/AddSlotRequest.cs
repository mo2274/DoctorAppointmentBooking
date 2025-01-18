namespace DoctorAvailability.Application.Requests;

public class AddSlotRequest
{
    public DateTime Time { get; set; }
    public decimal Cost { get; set; }
}