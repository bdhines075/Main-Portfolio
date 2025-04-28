using System.ComponentModel.DataAnnotations;

namespace GroupProject2.Models
{
    public class UserProfile
    {
        [Key]
        public string UserId { get; set; }

        public string DisplayName { get; set; } = string.Empty;

        public string BackgroundColor { get; set; } = "#FFFFFF";

        public string Font { get; set; } = "Arial";

        public string AvatarImage { get; set; } = "avatar1.jpg"; // fallback option if needed

        public string SelectedSong { get; set; } = ""; 

        public string CurrentMood { get; set; } = "";

        public string MoodEmoticon { get; set; } = "";
    }
}
