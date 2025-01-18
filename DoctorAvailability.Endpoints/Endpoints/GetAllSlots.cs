using DoctorAvailability.Application.Responses;
using DoctorAvailability.Application.Requests;
using DoctorAvailability.Application.Services;
using FastEndpoints;

namespace DoctorAvailability.Endpoints.Endpoints;

internal class GetAllSlots : Endpoint<PaginationRequest, GetAllSlotsResponse>
{
    private readonly SlotsService _slotsService;

    public override void Configure()
    {
        Get("/api/doctors/slots");
        AllowAnonymous();
    }

    public GetAllSlots(SlotsService slotsService)
    {
        _slotsService = slotsService;
    }

    public override async Task HandleAsync(PaginationRequest req, CancellationToken ct)
    {
        var slots = await _slotsService.GetAllSlots(req.Page, req.PageSize);
        
        await SendAsync(new GetAllSlotsResponse(slots), cancellation: ct);
    }
}