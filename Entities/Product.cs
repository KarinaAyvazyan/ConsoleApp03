using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    public class Product
    {
        public int Id { get;set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }   
        public string Description { get; set; } 

        public DateTime CreateTime { get; set; }

        
    }
}
