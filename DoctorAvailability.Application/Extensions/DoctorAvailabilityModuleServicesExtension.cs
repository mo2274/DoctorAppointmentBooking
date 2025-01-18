using DoctorAvailability.Application.Services;
using DoctorAvailability.Data;
using DoctorAvailability.Data.Repositories;
using DoctorAvailability.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorAvailability.Application.Extensions;

public static class DoctorAvailabilityModuleServicesExtension
{
    public static void AddDoctorAvailabilityModuleServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DoctorAvailabilityDbContext>(config =>
            config.UseSqlServer(configuration.GetConnectionString("DoctorAvailability")));
        
        services.AddScoped<SlotsService>();
        services.AddScoped<SlotsRepository>();
        services.AddScoped<IDoctorAvailabilityModuleApi, DoctorAvailabilityModuleApi>();
    }
}