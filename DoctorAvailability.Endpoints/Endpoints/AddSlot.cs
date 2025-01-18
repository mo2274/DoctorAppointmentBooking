using DoctorAvailability.Application.Requests;
using DoctorAvailability.Application.Responses;
using DoctorAvailability.Application.Services;
using FastEndpoints;

namespace DoctorAvailability.Endpoints.Endpoints;

public class AddSlot : Endpoint<AddSlotRequest, AddSlotResponse>
{
    private readonly SlotsService _slotsService;

    public override void Configure()
    {
        Post("/api/doctors/slots");
        AllowAnonymous();
    }

    public AddSlot(SlotsService slotsService)
    {
        _slotsService = slotsService;
    }

    public override async Task HandleAsync(AddSlotRequest req, CancellationToken ct)
    {
        var id = await _slotsService.AddSlot(req);
        
        await SendAsync(new AddSlotResponse(id), cancellation: ct);
    }
}