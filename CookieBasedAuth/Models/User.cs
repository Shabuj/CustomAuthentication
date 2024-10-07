using System.Data;

namespace CookieBasedAuth.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; } // Store hashed password
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
