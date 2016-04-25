using System.Collections.Generic;

namespace Music.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
    }
}