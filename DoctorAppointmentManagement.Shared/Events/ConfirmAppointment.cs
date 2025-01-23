using DoctorAppointmentBooking.Shared.Events;

namespace DoctorAppointmentManagement.Shared.Events;

public class ConfirmAppointment : IEvent
{
    public ConfirmAppointment(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}