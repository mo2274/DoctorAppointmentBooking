using AppointmentBooking.Application.Services;
using AppointmentBooking.Domain.Contracts;
using AppointmentBooking.Domain.Models;
using AppointmentBooking.Infrastructure.Database;
using AppointmentBooking.Infrastructure.Database.Repositories;
using AppointmentBooking.Infrastructure.Services;
using AppointmentBooking.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppointmentBooking.Infrastructure.Extensions;

public static class AppointmentBookingInfrastructureExtensions
{
    public static IServiceCollection AddAppointmentBookingInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppointmentBookingDbContext>(config =>
            config.UseSqlServer(configuration.GetConnectionString("AppointmentBooking")));
        
        // Repositories
        services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        
        // Services
        services.AddScoped<IAppointmentBookingModuleApi, AppointmentBookingModuleApi>();
        services.AddScoped<IAvailableSlotsService, AvailableSlotsService>();

        return services;
    }
}