using DoctorAppointmentManagement.Core.Contracts.Services;
using DoctorAppointmentManagement.Core.Requests;
using DoctorAppointmentManagement.Core.Responses;
using FastEndpoints;

namespace DoctorAppointmentManagement.Endpoints.Endpoints;

public class GetUpcomingAppointments : Endpoint<GetUpcomingAppointmentsRequest, GetUpcomingAppointmentsResponse>
{
    private readonly IAppointmentManagementService _appointmentManagementService;

    public GetUpcomingAppointments(IAppointmentManagementService appointmentManagementService)
    {
        _appointmentManagementService = appointmentManagementService;
    }
    
    public override void Configure()
    {
        Get("/api/appointments/upcoming");
        AllowAnonymous();
    }
    
    public override async Task HandleAsync(GetUpcomingAppointmentsRequest request, CancellationToken ct)
    {
        var appointments = await _appointmentManagementService.GetUpcomingAppointments(request.Page, request.PageSize);
        
        await SendAsync(new GetUpcomingAppointmentsResponse()
        {
            Appointments = appointments
        }, cancellation: ct);
    }
}