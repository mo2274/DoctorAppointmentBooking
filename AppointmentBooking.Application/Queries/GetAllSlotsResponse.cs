using AppointmentBooking.Domain.Dtos;

namespace AppointmentBooking.Application.Queries;

public record GetAllSlotsResponse(List<SlotDto> Slots);