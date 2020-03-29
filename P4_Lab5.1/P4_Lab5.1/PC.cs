using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Lab5._1
{
    public class PC : Computer
    {

        public string CoolingType { get; set; }
        public PC(string description, decimal prize, string coolingType)
            : base(description, prize)
        {
        CoolingType=coolingType;
        }
    }
}
