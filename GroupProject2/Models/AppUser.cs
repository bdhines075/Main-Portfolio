using Microsoft.AspNetCore.Identity;

namespace GroupProject2.Models

{
    public class AppUser : IdentityUser
    {
        public virtual ICollection<Event> Events { get; set; }
    }
}
