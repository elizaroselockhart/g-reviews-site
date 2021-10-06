﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public virtual List<Platform> Platforms { get; set; }
        public string Description { get; set; }
        //Eventually add a picture(virtual)
        // by url add a string feild
    }




}