using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo2.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int Status { get; set; }

        public OrderAddress OrderAddress { get; set; }
    }
}
