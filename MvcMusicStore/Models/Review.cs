﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        [Display(Name="Album")]
        public int AlbumID { get; set; }

        public Album Album { get; set; }
        
        public string Contents { get; set; }

        [Display(Name="Email Address")]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }

    }
}