using AppointmentBooking.Application.Extensions;
using AppointmentBooking.Endpoints;
using AppointmentBooking.Infrastructure.Extensions;
using DoctorAppointmentManagement.Endpoints;
using DoctorAppointmentManagement.Infrastructure.Extensions;
using DoctorAvailability.Application.Extensions;
using DoctorAvailability.Endpoints;
using FastEndpoints;
using FastEndpoints.Swagger;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints(o => o.Assemblies = new[]
    {
        typeof(DoctorAvailabilityAssemblyReference).Assembly,
        typeof(AppointmentBookingAssemblyReference).Assembly,
        typeof(DoctorManagementAssemblyReference).Assembly
    })
    .SwaggerDocument();

builder.Services.AddDoctorAvailabilityModuleServices(builder.Configuration);
builder.Services.AddAppointmentBookingApplicationServices();
builder.Services.AddAppointmentBookingInfrastructureServices(builder.Configuration);
builder.Services.AddDoctorAppointmentManagementServices();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseFastEndpoints()
    .UseSwaggerGen();

app.Run();