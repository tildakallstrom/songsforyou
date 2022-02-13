using System.ComponentModel.DataAnnotations;

namespace Mom2.Models
{
    public class SongModel
    {
        //properties
       
        //required - if not filled in correctly
        [Required(ErrorMessage = "Please fill in Song correctly.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please fill in album correctly.")]
        [MinLength(2)]
        public string? Album { get; set; }
        [Required(ErrorMessage = "Please fill in artist correctly.")]
        [MinLength(2)]
        public string? Artist { get; set; }
        [Required(ErrorMessage = "Please fill in Genre correctly.")]
        public string? Genre { get; set; }
        [Display(Name = "Listened to")]
        [Required(ErrorMessage = "Please fill in listened to correctly.")]
        public string? Listened { get; set; }
        [Display(Name = "Would you listen to this song again?")]
        [Required(ErrorMessage = "Please fill in would-listen-to correctly.")]
        public bool Listen { get; set; }
        [Display(Name = "Rate this song from 1(bad) to 5(best song in the world)")]
        [Required(ErrorMessage = "Please fill in rate correctly.")]
        public int? Review { get; set; }
        [Display(Name = "Add Url from youtubes embedded code - but only the URL.")]
        public string? Url { get; set; }
    }
}
