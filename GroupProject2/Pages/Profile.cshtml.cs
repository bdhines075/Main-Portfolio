using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using GroupProject2.Models;

using Microsoft.EntityFrameworkCore;
using GroupProject2.Data;

public class ProfileModel : PageModel
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly ApplicationDbContext _context;

    public IdentityUser CurrentUser { get; set; }
    public UserProfile CustomProfile { get; set; }



    public ProfileModel(UserManager<IdentityUser> userManager, ApplicationDbContext context)

    {
        _userManager = userManager;
        _context = context;
    }


    public async Task<IActionResult> OnGetAsync()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        CurrentUser = user;
        CustomProfile = await _context.UserProfiles.FindAsync(user.Id);
        if (CustomProfile == null)
        {
            CustomProfile = new UserProfile
            {
                UserId = user.Id,
                DisplayName = user.UserName
            };
            _context.UserProfiles.Add(CustomProfile);
            await _context.SaveChangesAsync();
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        var profile = await _context.UserProfiles.FindAsync(user.Id);
        if (profile == null)
        {
            profile = new UserProfile
            {
                UserId = user.Id,
                DisplayName = user.UserName
            };
            _context.UserProfiles.Add(profile);
        }

        profile.CurrentMood = Request.Form["CurrentMood"];
        profile.MoodEmoticon = Request.Form["MoodEmoticon"];
        await _context.SaveChangesAsync();

        return RedirectToPage();
    }
}


