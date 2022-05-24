using Microsoft.AspNetCore.Identity;

namespace SanPatrick.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Citizenship { get; set; }
        public int MaritalStatus { get; set; }
        public string Occupation { get; set; }
        public string PostCode { get; set; }
        public string Address { get; set; }
    }
}
