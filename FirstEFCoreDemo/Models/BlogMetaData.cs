﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEFCoreDemo.Models
{
    public class BlogMetaData
    {
        public int Id { get; set; }

        public string Content { get; set; }
    }
}
