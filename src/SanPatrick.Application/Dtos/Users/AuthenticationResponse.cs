using System.Text.Json.Serialization;

namespace SanPatrick.Application.Dtos.Users
{
    public class AuthenticationResponse
    {
        public string Id { get; set; } = String.Empty;
        public string UserName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public List<string>? Roles { get; set; }
        public bool IsVerified { get; set; }
        public string JWToken { get; set; } = String.Empty;
        [JsonIgnore]
        public string RefreshToken { get; set; } = String.Empty;
    }
}
