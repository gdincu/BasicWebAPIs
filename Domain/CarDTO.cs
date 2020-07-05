using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebAPI.Domain
{
    public class CarDTO
    {
        public int id { get; set; } //field
        public string name { get; set; }
        public int year { get; set; }
        public double price { get; set; }
        public int acceleration { get; set; }
        public int braking { get; set; }
    }
}
