using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Lab5._1
{
    public class Laptop :Computer
    {
        public Laptop(string description, decimal prize, double weight, string manufacturer)
            :base(description,prize)
        {
            Weight = weight;
            Manufacturer = manufacturer;
        }
        public double Weight { get; set; }
        public string Manufacturer { get; set; }
    }
}
