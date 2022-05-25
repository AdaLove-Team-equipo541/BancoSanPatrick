using Microsoft.AspNetCore.Identity;

namespace SanPatrick.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Citizenship { get; set; } = string.Empty;
        public int MaritalStatus { get; set; }
        public string Occupation { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
