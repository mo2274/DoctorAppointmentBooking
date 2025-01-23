using DoctorAppointmentBooking.Shared.Events;

namespace AppointmentBooking.Shared.Events;

public class AppointmentCreated : IEvent
{
    public AppointmentCreated(string patientName)
    {
        PatientName = patientName;
    }

    public string PatientName { get; set; }
}