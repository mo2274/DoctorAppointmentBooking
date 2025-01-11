using AppointmentBooking.Application.Requests;
using AppointmentBooking.Application.Responses;
using FastEndpoints;

namespace AppointmentBooking.Endpoints.Endpoints;

public class GetDoctorAvailableSlots : Endpoint<PaginationRequest, GetAllSlotsResponse>
{
    public override void Configure()
    {
        Post("/api/doctors/{id}/slots/available");
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