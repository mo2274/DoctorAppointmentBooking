using DoctorAppointmentBooking.Shared.Events;

namespace AppointmentBooking.Shared.Events;

public class AppointmentConfirmed : IEvent
{
    public AppointmentConfirmed(string patientName)
    {
        PatientName = patientName;
    }
    
    public string PatientName { get; set; }
}