using AppointmentBooking.Application.Commands;
using AppointmentBooking.Application.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace AppointmentBooking.Application.Extensions;

public static class AppointmentBookingServicesExtensions
{
    public static IServiceCollection AddAppointmentBookingApplicationServices(this IServiceCollection services)
    {
        // Command handlers
        services.AddScoped<CreateAppointmentHandler>();
        
        // Query handlers
        services.AddScoped<GetAvailableSlotsHandler>();
        
        return services;
    }
}