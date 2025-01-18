using AppointmentBooking.Application.Queries;
using FastEndpoints;

namespace AppointmentBooking.Endpoints.Endpoints;

public class GetAvailableSlotsEndpoint : Endpoint<GetAvailableSlots, GetAllSlotsResponse>
{
    private readonly GetAvailableSlotsHandler _handler;

    public override void Configure()
    {
        Get("/api/doctors/slots/available");
        AllowAnonymous();
    }

    public GetAvailableSlotsEndpoint(GetAvailableSlotsHandler handler)
    {
        _handler = handler;
    }

    public override async Task HandleAsync(GetAvailableSlots req, CancellationToken ct)
    {
        var slots = await _handler.Handle(req);
        
        await SendAsync(new GetAllSlotsResponse(slots), cancellation: ct);
    }
}