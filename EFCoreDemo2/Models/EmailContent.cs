using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo2.Models
{
    public class EmailContent
    {
        public string Title { get; set; }

        public string Content { get; set; }
    }
}