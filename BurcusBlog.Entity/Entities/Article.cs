﻿using BurcusBlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurcusBlog.Entity.Entities
{
    public class Article :EntityBase
    {
        public string Title { get; set;}
        public string Content { get; set;}
        public int ViewCount { get; set;}

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid? ImageId { get; set; }
        public Image Image { get; set; }

        public Guid UserId { get; set; }    
        public AppUser User { get; set; }

     
    }
}
