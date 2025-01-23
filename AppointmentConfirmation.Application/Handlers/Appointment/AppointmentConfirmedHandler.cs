using AppointmentBooking.Shared.Events;
using AppointmentConfirmation.Application.Services;
using DoctorAppointmentBooking.Shared.Events;

namespace AppointmentConfirmation.Application.Handlers.Appointment;

public class AppointmentConfirmedHandler : IEventHandler<AppointmentConfirmed>
{
    private readonly INotificationService _notificationService;

    public AppointmentConfirmedHandler(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    
    public async Task HandleAsync(AppointmentConfirmed @event, CancellationToken cancellationToken = default)
    {
        await _notificationService.SendNotification($"Appointment Confirmed for patient: {@event.PatientName}");
    }
}