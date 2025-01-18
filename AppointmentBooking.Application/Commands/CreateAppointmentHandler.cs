using AppointmentBooking.Domain.Models;

namespace AppointmentBooking.Application.Commands;

public class CreateAppointmentHandler
{
    private readonly IAppointmentRepository _appointmentRepository;

    public CreateAppointmentHandler(IAppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }
    
    public async Task Handle(CreateAppointment command, CancellationToken cancellationToken = default)
    {
        var appointment = Appointment.Create(command.SlotId, command.PatientId, command.PatientName, command.ReservedAt);
        
        await _appointmentRepository.Add(appointment, cancellationToken);
        
        // publish events
    }
}