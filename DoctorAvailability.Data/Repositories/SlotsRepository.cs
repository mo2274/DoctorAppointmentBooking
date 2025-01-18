using DoctorAvailability.Data.Dtos;
using DoctorAvailability.Data.Enitities;
using DoctorAvailability.Shared.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DoctorAvailability.Data.Repositories;

public class SlotsRepository 
{
    private readonly DoctorAvailabilityDbContext _dbContext;

    public SlotsRepository(DoctorAvailabilityDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<SlotDto>> GetAllSlots(int page, int pageSize)
    {
        return await _dbContext
            .Slots
            .Select(s => new SlotDto()
            {
                Time = s.Time,
                Cost = s.Cost,
                IsReserved = s.IsReserved
            })
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
    
    public async Task<Guid> AddSlot(Slot slot)
    {
        _dbContext.Slots.Add(slot);
        
        await _dbContext.SaveChangesAsync();
        
        return slot.Id;
    }
    
    public async Task<List<AvailableSlotDto>> GetAvailableSlots(int page, int pageSize)
    {
        return await _dbContext
            .Slots
            .Where(s => !s.IsReserved)
            .Select(s => new AvailableSlotDto()
            {
               
            })
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}