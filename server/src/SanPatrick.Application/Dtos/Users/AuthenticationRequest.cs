namespace SanPatrick.Application.Dtos.Users
{
    public class AuthenticationRequest
    {
        public string Email { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
    }
}
