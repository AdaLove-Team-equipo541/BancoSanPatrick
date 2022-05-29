using FluentValidation;

namespace SanPatrick.Application.Features.Users.Commands.RegisterUserCommand
{
    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidator()
        {
            RuleFor(p => p.Email)
                .NotNull().WithMessage("{PropertyName} es requerido")
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
                .EmailAddress().WithMessage("{PropertyName} No tiene un formato de email valido"); ;
            RuleFor(p => p.Password)
                .NotNull().WithMessage("{PropertyName} es requerido")
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
                .MinimumLength(6).WithMessage("{PropertyName} debe tener mas de 6 caracteres");
            RuleFor(p => p.ConfirmPassword)
                .NotNull().WithMessage("{PropertyName} es requerido")
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
                .Equal(p => p.Password).WithMessage("{PropertyName} debe ser igual al Password");
            RuleFor(p => p.PhoneNumber)
                .NotNull().WithMessage("{PropertyName} es requerido")
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
                .Matches("^[0-9]+$").WithMessage("{PropertyName} debe contener solo caracteres numericos");
            RuleFor(p => p.FirstName)
               .NotNull().WithMessage("{PropertyName} es requerido")
               .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
               .MaximumLength(30).WithMessage("{PropertyName} debe tener mas de 6 caracteres");
            RuleFor(p => p.MiddleName)
               .NotNull().WithMessage("{PropertyName} es requerido")
               .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
               .MaximumLength(30).WithMessage("{PropertyName} debe tener mas de 6 caracteres");
            RuleFor(p => p.LastName)
               .NotNull().WithMessage("{PropertyName} es requerido")
               .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
               .MaximumLength(30).WithMessage("{PropertyName} debe tener mas de 6 caracteres");
            RuleFor(p => p.BirthDate)
               .NotNull().WithMessage("{PropertyName} es requerido")
               .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
               .Length(10).WithMessage("{PropertyName} debe tener un formato dd/mm/yyyy ")
               
               .Matches(@"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|[2-9][0-9])\d\d$").WithMessage("{PropertyName} no tiene un formato valido");
            RuleFor(p => p.Citizenship)
               .NotNull().WithMessage("{PropertyName} es requerido")
               .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
               .MaximumLength(3).WithMessage("{PropertyName} debe tener 3 caracteres");
            RuleFor(p => p.MaritalStatus)
               .NotNull().WithMessage("{PropertyName} es requerido")
               .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
               .GreaterThan(0).WithMessage("{PropertyName} debe estar en el rango 1-4")
               .LessThan(5).WithMessage("{PropertyName} debe estar en el rango 1-4");
            RuleFor(p => p.Occupation)
              .NotNull().WithMessage("{PropertyName} es requerido")
              .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
              .MaximumLength(100).WithMessage("{PropertyName} debe tener maximo 100 caracteres");
            RuleFor(p => p.Country)
              .NotNull().WithMessage("{PropertyName} es requerido")
              .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
              .MaximumLength(100).WithMessage("{PropertyName} debe tener maximo 100 caracteres");
            RuleFor(p => p.City)
              .NotNull().WithMessage("{PropertyName} es requerido")
              .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
              .MaximumLength(100).WithMessage("{PropertyName} debe tener maximo 100 caracteres");
            RuleFor(p => p.Address)
              .NotNull().WithMessage("{PropertyName} es requerido")
              .NotEmpty().WithMessage("{PropertyName} no puede estar vacio")
              .MaximumLength(300).WithMessage("{PropertyName} debe tener maximo 100 caracteres");
        }
        private static bool IsDateTime(string fechaTemp)
        {
            DateTime fechaValidada;
            //Esto es la clave:
            var formatos = new[] { "MM/dd/yyyy", "dd/mm/yyyy", "dd/MM/yyyy h:mm:ss", "MM/dd/yyyy hh:mm tt", "yyyy'-'MM'-'dd'T'HH':'mm':'ss" };
            //Para revisar todos los formatos soportados: https://docs.microsoft.com/es-es/dotnet/standard/base-types/standard-date-and-time-format-strings
            return DateTime.TryParseExact(fechaTemp, formatos, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fechaValidada);
        }
    }
}
