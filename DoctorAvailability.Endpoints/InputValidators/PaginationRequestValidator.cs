using DoctorAvailability.Application.Requests;
using FastEndpoints;
using FluentValidation;


namespace DoctorAvailability.Endpoints.InputValidators;

public class PaginationRequestValidator : Validator<PaginationRequest>
{
    public PaginationRequestValidator()
    {
        RuleFor(x => x.Page)
            .GreaterThan(0)
            .WithMessage("Page number must be greater than 0.");
        
        RuleFor(x => x.PageSize)
            .GreaterThan(0)
            .WithMessage("Page size must be greater than 0.");
    }
}