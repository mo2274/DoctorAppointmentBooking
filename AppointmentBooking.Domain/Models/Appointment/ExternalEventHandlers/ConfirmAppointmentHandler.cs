using AppointmentBooking.Shared.Events;
using DoctorAppointmentBooking.Shared.Events;
using DoctorAppointmentBooking.Shared.Messaging;
using DoctorAppointmentManagement.Shared.Events;

namespace AppointmentBooking.Domain.Models.ExternalEventHandlers;

public class ConfirmAppointmentHandler : IEventHandler<ConfirmAppointment>
{
    private readonly IAppointmentRepository _appointmentRepository;
    private readonly IMessageBroker _messageBroker;

    public ConfirmAppointmentHandler(IAppointmentRepository appointmentRepository, IMessageBroker messageBroker)
    {
        _appointmentRepository = appointmentRepository;
        _messageBroker = messageBroker;
    }
    
    public async Task HandleAsync(ConfirmAppointment @event, CancellationToken cancellationToken = default)
    {
        var appointment = await _appointmentRepository.GetAsync(@event.Id);
        
        appointment.Confirm();
        
        await _appointmentRepository.UpdateAsync(appointment, cancellationToken);
        
        await _messageBroker.PublishAsync(new AppointmentConfirmed(appointment.PatientName.Get()), cancellationToken);
    }
}