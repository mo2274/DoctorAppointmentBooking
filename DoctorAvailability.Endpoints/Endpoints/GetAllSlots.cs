using DoctorAvailability.Application.Responses;
using DoctorAvailability.BusinessLogic.Requests;
using FastEndpoints;

namespace DoctorAvailability.Endpoints.Endpoints;

internal class GetAllSlots : Endpoint<PaginationRequest, GetAllSlotsResponse>
{
    public override void Configure()
    {
        Post("/api/doctors/{id}/slots");
        AllowAnonymous();
    }

    public override async Task HandleAsync(PaginationRequest req, CancellationToken ct)
    {
        var doctorId =  Route<int>("id");
        
        await SendAsync(new GetAllSlotsResponse
        {
            
        }, cancellation: ct);
    }
}