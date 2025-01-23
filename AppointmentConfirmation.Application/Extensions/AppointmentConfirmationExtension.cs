using AppointmentConfirmation.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AppointmentConfirmation.Application.Extensions;

public static class AppointmentConfirmationExtension
{
    public static IServiceCollection AddAppointmentConfirmationServices(this IServiceCollection services)
    {
        services.AddScoped<INotificationService, NotificationService>();

        return services;
    }
}