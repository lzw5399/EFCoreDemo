using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Model.QueryResult
{
    public class BlogPostsCount
    {
        public string BlogName { get; set; }
        public int PostCount { get; set; }
    }
}