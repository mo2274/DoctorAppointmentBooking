using FastEndpoints;

namespace DoctorAvailability.BusinessLogic.Requests;

public class PaginationRequest
{
    [FromQuery]
    public int Page { get; set; }
    
    [FromQuery]
    public int PageSize { get; set; }
}