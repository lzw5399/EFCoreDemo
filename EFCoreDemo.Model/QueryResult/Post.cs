﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Model.QueryResult
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
    }
}