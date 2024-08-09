using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkP3.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Price { get; set; }

        public override string ToString() => $"Id: {Id}, Name: {Name}, Price: {Price}";

    }
    
}
