using DoctorAvailability.Data.Dtos;

namespace DoctorAvailability.Application.Responses;

public record GetAllSlotsResponse(List<SlotDto> Slots);