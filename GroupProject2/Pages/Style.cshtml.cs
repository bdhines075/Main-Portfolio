using GroupProject2.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GroupProject2.Models;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GroupProject2.Pages
{
    public class StyleModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public StyleModel(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [BindProperty]
        public UserProfile UserProfile { get; set; } = null!;

        public List<SelectListItem> AvailableAvatars { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "avatar1.jpg", Text = "Girly DVD" },
            new SelectListItem { Value = "avatar2.jpg", Text = "Boom Box" },
            new SelectListItem { Value = "avatar3.jpg", Text = "Casette Tape" },
            new SelectListItem { Value = "avatar4.jpg", Text = "Gameboy" },
            new SelectListItem { Value = "avatar5.jpg", Text = "Computer" }
        };

        public bool IsLoggedIn { get; set; }

        public async Task OnGetAsync()
        {
            IsLoggedIn = User.Identity.IsAuthenticated;
            if (!IsLoggedIn) return;

            var user = await _userManager.GetUserAsync(User);
            UserProfile = await _context.UserProfiles.FindAsync(user.Id);

            if (UserProfile == null)
            {
                UserProfile = new UserProfile { UserId = user.Id };
                _context.UserProfiles.Add(UserProfile);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }

            var existingProfile = await _context.UserProfiles.FindAsync(user.Id);
            if (existingProfile == null)
            {
                UserProfile.UserId = user.Id;
                _context.UserProfiles.Add(UserProfile);
            }
            else
            {
                // Update the existing profile with form values
                existingProfile.DisplayName = UserProfile.DisplayName;
                existingProfile.BackgroundColor = UserProfile.BackgroundColor;
                existingProfile.Font = UserProfile.Font;
                existingProfile.AvatarImage = UserProfile.AvatarImage;
                existingProfile.CurrentMood = UserProfile.CurrentMood;
                existingProfile.MoodEmoticon = UserProfile.MoodEmoticon;
            }

            await _context.SaveChangesAsync();
            return RedirectToPage("/Profile");
        }
    }
}
