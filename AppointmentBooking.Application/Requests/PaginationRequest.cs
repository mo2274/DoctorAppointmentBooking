using FastEndpoints;

namespace AppointmentBooking.Application.Requests;

public class PaginationRequest
{
    [FromQuery]
    public int Page { get; set; }
    
    [FromQuery]
    public int PageSize { get; set; }
}