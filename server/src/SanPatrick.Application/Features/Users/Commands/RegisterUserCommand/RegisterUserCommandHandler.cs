using MediatR;
using SanPatrick.Application.Dtos.Users;
using SanPatrick.Application.Interfaces;
using SanPatrick.Application.Wrappers;

namespace SanPatrick.Application.Features.Users.Commands.RegisterUserCommand
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, Response<string>>
    {
        private readonly IAccountService _accountService;

        public RegisterUserCommandHandler(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public async Task<Response<string>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            return await _accountService.RegisterAsync(new RegistrationRequest
            {
                Email = request.Email,
                Password = request.Password,
                ConfirmPassword = request.ConfirmPassword,
                FirstName = request.FirstName,
                PhoneNumber = request.PhoneNumber,
                MiddleName = request.MiddleName,
                LastName = request.LastName,
                BirthDate = request.BirthDate,
                AvatarString = request.AvatarString,

                Citizenship = request.Citizenship,
                MaritalStatus = request.MaritalStatus,
                Occupation = request.Occupation,

                Country = request.Country,
                City = request.City,
                Address = request.Address
            }, request.Origin);
        }
    }
}
