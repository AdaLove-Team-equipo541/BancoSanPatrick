﻿using FluentValidation;

namespace SanPatrick.Application.UseCases.User.Authenticate
{
    public class AuthenticateUserCommandValidator : AbstractValidator<AuthenticateUserCommand>
    {
        public AuthenticateUserCommandValidator()
        {
            RuleFor(p => p.Email)
                .NotNull().WithMessage("{PropertyName} es requerido")
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
                .EmailAddress().WithMessage("{PropertyName} No tiene un formato de email valido");
        }
    }
}
