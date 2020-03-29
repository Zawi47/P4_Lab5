using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Lab5._1
{
    public class TPCContext:DbContext
    {
        public DbSet<Computer> Computers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PC>().Map(map=>
            {
                map.MapInheritedProperties();
                map.ToTable("PCs");
            });

            modelBuilder.Entity<Laptop>().Map(map =>
            {
                map.MapInheritedProperties();
                map.ToTable("Laptops");
            });
        }
    }
}
