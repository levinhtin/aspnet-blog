﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Category: AbstractModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
