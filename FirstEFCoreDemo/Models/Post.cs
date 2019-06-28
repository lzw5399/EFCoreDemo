using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ConcurrencyCheck]
        public string Content { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        // 外键
        // public int BlogId { get; set; }
        public int FFF { get; set; }

        [ForeignKey(nameof(FFF))]
        public Blog Blog { get; set; }
    }
}
