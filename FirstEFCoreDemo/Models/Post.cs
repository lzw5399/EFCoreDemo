using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEFCoreDemo.Models
{
    /// <summary>
    /// 文章类
    /// </summary>
    public class Post
    {
        public int PostId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreateDate { get; set; }

        // 外键
        public int BlogId { get; set; }
    }
}
