using System.ComponentModel.DataAnnotations;

namespace GroupProject2.Models

{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        
        //Relational Data
        public virtual ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
