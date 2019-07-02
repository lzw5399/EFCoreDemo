using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Model.QueryResult
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}