﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo2.Models
{
    public class Email
    {
        private string _test;

        public int Id { get; set; }

        public string MailFrom { get; set; }

        public string MailTo { get; set; }

        public EmailContent EmailContent { get; set; }

        public string Test
        {
            get
            {
                return _test;
            }
        }
    }
}
