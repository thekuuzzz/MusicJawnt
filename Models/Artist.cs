using System.ComponentModel.DataAnnotations;

namespace Music.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        [Required(ErrorMessage = "Artist ID is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Artist Name is required")]
        public string Bio { get; set; }
    }
}