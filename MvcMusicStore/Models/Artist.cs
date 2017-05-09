using System.ComponentModel.DataAnnotations;
namespace MvcMusicStore.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        [Display(Name="Artist Name")]
        public string Name { get; set; }

        

    }
}