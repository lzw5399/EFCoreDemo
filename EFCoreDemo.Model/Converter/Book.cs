using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Model.Converter
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public BookType Type { get; set; }
    }
}
