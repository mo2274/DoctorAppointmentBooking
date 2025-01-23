using System.Threading;
using System.Threading.Tasks;
using DoctorAppointmentBooking.Shared.Events;

namespace DoctorAppointmentBooking.Shared.Messaging;

public interface IMessageBroker
{
    Task PublishAsync(IEvent @event, CancellationToken cancellationToken = default);
}