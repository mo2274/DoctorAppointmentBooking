using AppointmentBooking.Domain.Models;
using AppointmentBooking.Shared.Events;
using DoctorAppointmentBooking.Shared.Messaging;

namespace AppointmentBooking.Application.Commands;

public class CreateAppointmentHandler
{
    private readonly IAppointmentRepository _appointmentRepository;
    private readonly IMessageBroker _messageBroker;

    public CreateAppointmentHandler(IAppointmentRepository appointmentRepository, IMessageBroker messageBroker)
    {
        _appointmentRepository = appointmentRepository;
        _messageBroker = messageBroker;
    }
    
    public async Task Handle(CreateAppointment command, CancellationToken cancellationToken = default)
    {
        var appointment = Appointment.Create(command.SlotId, command.PatientId, command.PatientName, command.ReservedAt);
        
        await _appointmentRepository.Add(appointment, cancellationToken);
        
        await _messageBroker.PublishAsync(new AppointmentCreated(appointment.PatientName.Get()), cancellationToken);
    }
}