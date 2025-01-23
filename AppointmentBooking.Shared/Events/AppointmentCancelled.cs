using DoctorAppointmentBooking.Shared.Events;

namespace AppointmentBooking.Shared.Events;

public class AppointmentCancelled : IEvent
{
    public AppointmentCancelled(string patientName)
    {
        PatientName = patientName;
    }
    
    public string PatientName { get; set; }
}