using DoctorAppointmentBooking.Shared.Events;

namespace DoctorAppointmentBooking.Shared.Messaging;

internal interface IAsyncEventDispatcher
{
    Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default)
        where TEvent : class, IEvent;
}