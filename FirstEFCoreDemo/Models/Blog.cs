using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEFCoreDemo.Models
{
    /// <summary>
    /// 博客类
    /// </summary>
    public class Blog
    {
        public int BlogId { get; set; }

        public string Url { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
