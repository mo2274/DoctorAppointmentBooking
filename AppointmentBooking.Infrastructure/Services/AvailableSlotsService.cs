using AppointmentBooking.Domain.Contracts;
using AppointmentBooking.Domain.Dtos;
using DoctorAvailability.Shared;

namespace AppointmentBooking.Infrastructure.Services;

public class AvailableSlotsService : IAvailableSlotsService
{
    private readonly IDoctorAvailabilityModuleApi _doctorAvailabilityModuleApi;

    public AvailableSlotsService(IDoctorAvailabilityModuleApi doctorAvailabilityModuleApi)
    {
        _doctorAvailabilityModuleApi = doctorAvailabilityModuleApi;
    }

    public async Task<List<SlotDto>> GetAvailableSlots(int page, int pageSize)
    {
        var slots = await _doctorAvailabilityModuleApi.GetAvailableSlots(page, pageSize);
        
        return slots.Select(s => new SlotDto()
        {
            Id = s.Id,
            Time = s.Time,
            Cost = s.Cost
        }).ToList();
    }
    
}