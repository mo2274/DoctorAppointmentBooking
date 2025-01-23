using AppointmentBooking.Shared.Events;
using AppointmentConfirmation.Application.Services;
using DoctorAppointmentBooking.Shared.Events;

namespace AppointmentConfirmation.Application.Handlers.Appointment;

public class AppointmentCreatedHandler : IEventHandler<AppointmentCreated>
{
    private readonly INotificationService _notificationService;

    public AppointmentCreatedHandler(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    
    public async Task HandleAsync(AppointmentCreated @event, CancellationToken cancellationToken = default)
    {
        await _notificationService.SendNotification($"Appointment Created for patient: {@event.PatientName}");
    }
}