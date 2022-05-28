using FluentValidation;

namespace SanPatrick.Application.Features.Users.Commands.AuthenticateUser
{
    public class AuthenticateUserCommandValidator : AbstractValidator<AuthenticateUserCommand>
    {
        public AuthenticateUserCommandValidator()
        {
            RuleFor(p => p.Email)
                .EmailAddress().WithMessage("{PropertyName} No tiene un formato de email valido");
        }
    }
}
