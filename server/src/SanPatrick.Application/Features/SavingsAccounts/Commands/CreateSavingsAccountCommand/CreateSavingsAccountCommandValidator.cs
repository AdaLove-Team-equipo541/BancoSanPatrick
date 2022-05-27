using FluentValidation;

namespace SanPatrick.Application.Features.SavingsAccounts.Commands.CreateSavingsAccountCommand
{
    public class CreateSavingsAccountCommandValidator : AbstractValidator<CreateSavingsAccountCommand>
    {
        public CreateSavingsAccountCommandValidator()
        {
            RuleFor(p => p.Alias)
                .MaximumLength(30).WithMessage("{PropertyName} debe tener un maximo de 30 caracteres")
                .Matches("^[a-zA-Z]*$").WithMessage("{PropertyName} debe contener solo caracteres alfabeticos");
        }
    }
}
