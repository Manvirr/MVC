using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        [Display(Name ="Album Title")]
        public string Title { get; set; }

        public int ArtistID { get; set; }

        public Artist Artist { get; set; }

        public List<Review> Reviews { get; set; }
        
        
    }
}