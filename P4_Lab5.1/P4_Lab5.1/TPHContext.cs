using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Lab5._1
{
    class TPHContext: DbContext
    {
        public DbSet<Computer> Computers { get; set; }
    }
}
