using AppointmentBooking.Application.Commands;
using FastEndpoints;

namespace AppointmentBooking.Endpoints.Endpoints;

public class CreateAppointmentEndpoint : Endpoint<CreateAppointment>
{
    private readonly CreateAppointmentHandler _handler;

    public override void Configure()
    {
        Post("/api/doctors/appointments");
        AllowAnonymous();
    }

    public CreateAppointmentEndpoint(CreateAppointmentHandler handler)
    {
        _handler = handler;
    }

    public override async Task HandleAsync(CreateAppointment req, CancellationToken ct)
    {
        await _handler.Handle(req, ct);
    }
}