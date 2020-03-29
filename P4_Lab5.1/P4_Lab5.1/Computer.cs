using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Lab5._1
{
    public abstract class Computer
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public decimal Prize { get; set; }

        protected Computer ( string description, decimal prize)
        {
            
            Description = description;
            Prize = prize;
        }
    }
}
