using DoctorAvailability.Application.Requests;
using FastEndpoints;
using FluentValidation;

namespace DoctorAvailability.Endpoints.InputValidators;

public class AddSlotRequestValidator : Validator<AddSlotRequest>
{
    public AddSlotRequestValidator()
    {
        RuleFor(x => x.Time)
            .GreaterThan(DateTime.Now)
            .WithMessage("Time must be in the future");
        
        RuleFor(x => x.Cost)
            .GreaterThan(0)
            .WithMessage("Cost must be greater than 0");
    }
}