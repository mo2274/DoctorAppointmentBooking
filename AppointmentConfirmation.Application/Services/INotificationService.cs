namespace AppointmentConfirmation.Application.Services;

public interface INotificationService
{
    Task SendNotification(string message);
}