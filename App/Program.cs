using AppointmentBooking.Endpoints;
using DoctorAvailability.Endpoints;
using FastEndpoints;
using FastEndpoints.Swagger;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints(o => o.Assemblies = new[]
    {
        typeof(DoctorAvailabilityAssemblyReference).Assembly,
        typeof(AppointmentBookingAssemblyReference).Assembly
    })
    .SwaggerDocument();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseFastEndpoints()
    .UseSwaggerGen();

app.Run();