﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public double Rating { get; set; }
        public string Usercomment { get; set; }
        public string Username { get; set; }
    }
}
