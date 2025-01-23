namespace DoctorAppointmentManagement.Core.Requests;

public class GetUpcomingAppointmentsRequest
{
    public int Page { get; set; }
    public int PageSize { get; set; }
}