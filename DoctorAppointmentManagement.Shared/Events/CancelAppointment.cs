using DoctorAppointmentBooking.Shared.Events;

namespace DoctorAppointmentManagement.Shared.Events;

public class CancelAppointment : IEvent
{
    public CancelAppointment(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}