using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkP3.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public string Address { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public override string ToString() => $"Id {Id} Address {Address} CreatedAt {CreatedAt}";
        

    }
}
