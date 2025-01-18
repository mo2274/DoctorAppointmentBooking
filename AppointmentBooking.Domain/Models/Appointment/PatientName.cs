namespace AppointmentBooking.Domain.Models;

public class PatientName
{
    private const int MaxLength = 100;
    private readonly string _value;
    
    public PatientName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Patient name cannot be empty");

        if (value.Length > MaxLength)
            throw new ArgumentException("Patient name cannot be longer than 100 characters");
        
        _value = value;
    }
    
    public static PatientName Create(string value) => new(value);
    
    public string Get() => _value;
}