using DoctorAppointmentManagement.Core.Contracts.Infrastructure;
using DoctorAppointmentManagement.Core.Contracts.Services;
using DoctorAppointmentManagement.Core.Services;
using DoctorAppointmentManagement.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorAppointmentManagement.Infrastructure.Extensions;

public static class DoctorAppointmentManagementExtension
{
    public static IServiceCollection AddDoctorAppointmentManagementServices(this IServiceCollection services)
    {
        services.AddScoped<IAppointmentService, AppointmentService>();
        services.AddScoped<IAppointmentManagementService, AppointmentManagementService>();
        
        return services;
    }
}