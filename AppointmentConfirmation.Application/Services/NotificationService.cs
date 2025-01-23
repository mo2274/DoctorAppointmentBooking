namespace AppointmentConfirmation.Application.Services;

public class NotificationService : INotificationService
{
    public Task SendNotification(string message)
    {
        Console.WriteLine(message);
        
        return Task.CompletedTask;
    }
}