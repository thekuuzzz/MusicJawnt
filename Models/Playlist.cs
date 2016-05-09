using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Music.Models
{
    public class Playlist
    {
        
        public string Name { get; set; }
        [Required(ErrorMessage = "Playlist Name is required")]
        public string Info { get; set; }
    }
}