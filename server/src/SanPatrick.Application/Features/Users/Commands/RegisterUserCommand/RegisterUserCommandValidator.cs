using FluentValidation;

namespace SanPatrick.Application.Features.Users.Commands.RegisterUserCommand
{
    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidator()
        {
            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacio");
            RuleFor(p => p.Password)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacio");
            RuleFor(p => p.Password)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
                .Equal(p => p.Password).WithMessage("{PropertyName} debe ser igual al Password");
            RuleFor(p => p.Username)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacio");
        }
    }
}
