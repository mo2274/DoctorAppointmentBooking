using AppointmentBooking.Shared.Events;
using AppointmentConfirmation.Application.Services;
using DoctorAppointmentBooking.Shared.Events;

namespace AppointmentConfirmation.Application.Handlers.Appointment;

public class AppointmentCancelledHandler : IEventHandler<AppointmentCancelled>
{
    private readonly INotificationService _notificationService;

    public AppointmentCancelledHandler(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    
    public async Task HandleAsync(AppointmentCancelled @event, CancellationToken cancellationToken = default)
    {
        await _notificationService.SendNotification($"Appointment Cancelled for patient: {@event.PatientName}");
    }
}