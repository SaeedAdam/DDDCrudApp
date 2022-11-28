using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public  class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }
}
