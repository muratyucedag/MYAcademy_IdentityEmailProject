using Microsoft.AspNetCore.Identity;

namespace MYAcademy_IdentityEmailProject.Entities
{
    public class AppUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
