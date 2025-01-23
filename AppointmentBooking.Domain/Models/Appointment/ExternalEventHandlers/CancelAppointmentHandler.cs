using AppointmentBooking.Shared.Events;
using DoctorAppointmentBooking.Shared.Events;
using DoctorAppointmentBooking.Shared.Messaging;
using DoctorAppointmentManagement.Shared.Events;

namespace AppointmentBooking.Domain.Models.ExternalEventHandlers;

public class CancelAppointmentHandler : IEventHandler<CancelAppointment>
{
    private readonly IAppointmentRepository _appointmentRepository;
    private readonly IMessageBroker _messageBroker;

    public CancelAppointmentHandler(IAppointmentRepository appointmentRepository, IMessageBroker messageBroker)
    {
        _appointmentRepository = appointmentRepository;
        _messageBroker = messageBroker;
    }
    
    public async Task HandleAsync(CancelAppointment @event, CancellationToken cancellationToken = default)
    {
        var appointment = await _appointmentRepository.GetAsync(@event.Id);
        
        appointment.Cancel();
        
        await _appointmentRepository.UpdateAsync(appointment, cancellationToken);
        
        await _messageBroker.PublishAsync(new AppointmentCancelled(appointment.PatientName.Get()), cancellationToken);
    }
}