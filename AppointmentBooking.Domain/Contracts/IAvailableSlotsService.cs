using AppointmentBooking.Domain.Dtos;

namespace AppointmentBooking.Domain.Contracts;

public interface IAvailableSlotsService
{
    Task<List<SlotDto>> GetAvailableSlots(int page, int pageSize);
}