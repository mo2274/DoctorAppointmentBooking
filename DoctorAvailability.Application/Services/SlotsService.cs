using DoctorAvailability.Application.Requests;
using DoctorAvailability.Data.Dtos;
using DoctorAvailability.Data.Enitities;
using DoctorAvailability.Data.Repositories;
using DoctorAvailability.Shared.Dtos;

namespace DoctorAvailability.Application.Services;

public class SlotsService
{
    private readonly SlotsRepository _slotsRepository;

    public SlotsService(SlotsRepository slotsRepository)
    {
        _slotsRepository = slotsRepository;
    }
    
    public async Task<List<SlotDto>> GetAllSlots(int page, int pageSize)
    {
        return await _slotsRepository.GetAllSlots(page, pageSize);
    }

    public async Task<Guid> AddSlot(AddSlotRequest req)
    {
        var slot = new Slot
        {
            Time = req.Time,
            Cost = req.Cost
        };

        return await _slotsRepository.AddSlot(slot);
    }
    
    public async Task<List<AvailableSlotDto>> GetAvailableSlots(int page, int pageSize)
    {
        return await _slotsRepository.GetAvailableSlots(page, pageSize);
    }
}