using MediatR;
using SanPatrick.Application.Dtos.Users;
using SanPatrick.Application.Wrappers;

namespace SanPatrick.Application.Features.Users.Commands.AuthenticateUser
{
    public class AuthenticateUserCommand : IRequest<Response<AuthenticationResponse>>
    {
        public string Email { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public string IpAddress { get; set; }
    }
}
