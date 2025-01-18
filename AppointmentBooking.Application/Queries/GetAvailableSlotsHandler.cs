using AppointmentBooking.Domain.Contracts;
using AppointmentBooking.Domain.Dtos;

namespace AppointmentBooking.Application.Queries;

public class GetAvailableSlotsHandler
{
    private readonly IAvailableSlotsService _availableSlotsService;

    public GetAvailableSlotsHandler(IAvailableSlotsService availableSlotsService)
    {
        _availableSlotsService = availableSlotsService;
    }
    
    public async Task<List<SlotDto>> Handle(GetAvailableSlots req)
    {
        return await _availableSlotsService.GetAvailableSlots(req.Page, req.PageSize);
    }
}