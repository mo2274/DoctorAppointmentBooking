using DoctorAppointmentBooking.Shared.Messaging;
using DoctorAppointmentManagement.Core.Contracts.Infrastructure;
using DoctorAppointmentManagement.Core.Contracts.Services;
using DoctorAppointmentManagement.Core.Dto;
using DoctorAppointmentManagement.Core.Enums;
using DoctorAppointmentManagement.Core.Requests;
using DoctorAppointmentManagement.Shared.Events;

namespace DoctorAppointmentManagement.Core.Services;

public class AppointmentManagementService : IAppointmentManagementService
{
    private readonly IAppointmentService _appointmentService;
    private readonly IMessageBroker _messageBroker;

    public AppointmentManagementService(IAppointmentService appointmentService, IMessageBroker messageBroker)
    {
        _appointmentService = appointmentService;
        _messageBroker = messageBroker;
    }

    public async Task<List<AppointmentDto>> GetUpcomingAppointments(int page, int pageSize)
    {
        return await _appointmentService.GetUpcomingAppointment(page, pageSize);
    }

    public async Task UpdateAppointmentStatus(Guid id, UpdateAppointmentStatusRequest request)
    {
        switch (request.Status)
        {
            case AppointmentStatus.Cancelled:
                await _messageBroker.PublishAsync(new CancelAppointment(id));
                break;
            case AppointmentStatus.Confirmed:
                await _messageBroker.PublishAsync(new ConfirmAppointment(id));
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}