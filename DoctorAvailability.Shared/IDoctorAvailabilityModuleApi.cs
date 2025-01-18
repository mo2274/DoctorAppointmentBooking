using DoctorAvailability.Shared.Dtos;

namespace DoctorAvailability.Shared;

public interface IDoctorAvailabilityModuleApi
{
    Task<List<AvailableSlotDto>> GetAvailableSlots(int page, int pageSize);
}