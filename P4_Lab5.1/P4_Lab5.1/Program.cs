using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Lab5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tph = new TPHContext();
            tph.Computers.Add(new PC("Standard PD", 1000, "Air"));
            tph.SaveChanges();

            var tpt = new TPTContext();
            tpt.Computers.Add(new PC("Standard PD", 1000, "Air"));
            tpt.SaveChanges();

            var tpc = new TPCContext();
            tpc.Computers.Add(new PC("Standard PD", 1000, "Air"));
            tpc.SaveChanges();
        }
    }
}
