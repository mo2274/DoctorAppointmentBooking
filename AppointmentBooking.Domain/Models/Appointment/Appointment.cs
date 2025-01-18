namespace AppointmentBooking.Domain.Models;

public class Appointment
{
    public Guid Id { get; }
    public Guid SlotId { get; }
    public Guid PatientId { get; }
    public DateTime ReservedAt { get; }
    public PatientName PatientName { get; }
    public AppointmentStatus Status { get; private set; }

    public Appointment(Guid slotId, Guid patientId, string patientName, DateTime reservedAt, AppointmentStatus status = AppointmentStatus.Pending)
    {
        Id = Guid.NewGuid();
        SlotId = slotId;
        PatientId = patientId;
        PatientName = PatientName.Create(patientName);
        ReservedAt = reservedAt;
        Status = status;
    }
    
    public static Appointment Create(Guid slotId, Guid patientId, string patientName, DateTime reservedAt)
    {
        var appointment = new Appointment(slotId, patientId, patientName, reservedAt);
        
        if (appointment.Status == AppointmentStatus.Pending)
        {
            // Raise event
        }
        
        return appointment;
    }
    
    public void Confirm()
    {
        Status = AppointmentStatus.Confirmed;
        
        // Raise event
    }
    
    public void Cancel()
    {
        Status = AppointmentStatus.Cancelled;

        // Raise event
    }

}

public enum AppointmentStatus
{
    Pending,
    Confirmed,
    Cancelled
}