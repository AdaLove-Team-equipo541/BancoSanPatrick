using MediatR;
using SanPatrick.Application.Wrappers;

namespace SanPatrick.Application.Features.Users.Commands.RegisterUserCommand
{
    public class RegisterUserCommand : IRequest<Response<string>>
    {
        public string Email { get; set; } = String.Empty;
        public string Username { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public string ConfirmPassword { get; set; } = String.Empty;

        public string FirstName { get; set; } = String.Empty;
        public string MiddleName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string BirthDate { get; set; } = String.Empty;
        public string Citizenship { get; set; } = String.Empty;
        public int MaritalStatus { get; set; }
        public string Occupation { get; set; } = String.Empty;
        public string PhoneNumber { get; set; } = String.Empty;
        public string Contry { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;


        public string AvatarString { get; set; } = String.Empty;
        public string Origin { get; set; }
    }
}
