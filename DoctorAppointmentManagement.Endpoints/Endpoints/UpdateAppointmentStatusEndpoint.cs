using DoctorAppointmentManagement.Core.Contracts.Services;
using DoctorAppointmentManagement.Core.Requests;
using DoctorAppointmentManagement.Core.Responses;
using FastEndpoints;

namespace DoctorAppointmentManagement.Endpoints.Endpoints;

public class UpdateAppointmentStatusEndpoint : Endpoint<UpdateAppointmentStatusRequest, UpdateAppointmentStatusResponse>
{
    private readonly IAppointmentManagementService _appointmentManagementService;

    public UpdateAppointmentStatusEndpoint(IAppointmentManagementService appointmentManagementService)
    {
        _appointmentManagementService = appointmentManagementService;
    }
    
    public override void Configure()
    {
        Put("/api/appointments/{id}/status");
        AllowAnonymous();
    }
    
    public override async Task HandleAsync(UpdateAppointmentStatusRequest request, CancellationToken ct)
    {
        var id = Route<Guid>("id");
        
        await _appointmentManagementService.UpdateAppointmentStatus(id, request);
        
        await SendAsync(new UpdateAppointmentStatusResponse()
        {
        }, cancellation: ct);
    }
}