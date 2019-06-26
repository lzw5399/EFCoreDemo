using System;
using System.Collections.Generic;

namespace FirstEFCoreDemo.DbFirstProcess
{
    public partial class Posts
    {
        public int PostId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int BlogId { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Blogs Blog { get; set; }
    }
}