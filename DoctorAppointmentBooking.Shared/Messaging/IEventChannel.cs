using System.Threading.Channels;
using DoctorAppointmentBooking.Shared.Events;

namespace DoctorAppointmentBooking.Shared.Messaging;

internal interface IEventChannel
{
    ChannelReader<IEvent> Reader { get; }
    ChannelWriter<IEvent> Writer { get; }
}