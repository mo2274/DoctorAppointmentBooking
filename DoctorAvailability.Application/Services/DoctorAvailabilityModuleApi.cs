using DoctorAvailability.Shared;
using DoctorAvailability.Shared.Dtos;

namespace DoctorAvailability.Application.Services;

public class DoctorAvailabilityModuleApi : IDoctorAvailabilityModuleApi
{
    private readonly SlotsService _slotsService;

    public DoctorAvailabilityModuleApi(SlotsService slotsService)
    {
        _slotsService = slotsService;
    }
    
    public Task<List<AvailableSlotDto>> GetAvailableSlots(int page, int pageSize)
        => _slotsService.GetAvailableSlots(page, pageSize);
}