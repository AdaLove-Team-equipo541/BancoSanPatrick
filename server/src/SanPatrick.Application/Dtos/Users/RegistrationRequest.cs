using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPatrick.Application.Dtos.Users
{
    public class RegistrationRequest
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Citizenship { get; set; }
        public int MaritalStatus { get; set; }
        public string Occupation { get; set; }
        public string PhoneNumber { get; set; }
        public string Contry { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        
        
        public string AvatarString { get; set; }
    }
}
