using SanPatrick.Application.Dtos.Users;
using SanPatrick.Application.Wrappers;

namespace SanPatrick.Application.Interfaces
{
    public interface IAccountService
    {
        Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress);
        Task<Response<string>> RegisterAsync(RegistrationRequest request, string origin);
    }
}
