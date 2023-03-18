using System;
using System.Data.Entity;
using System.Linq;

namespace WpfApp1
{
    public class ContextCafe : DbContext
    {
        
        public ContextCafe()
            : base("name=ContextCafe")
        {
        }

        public DbSet <Cofe> Cofes { get; set; }
        public DbSet <Dobavki> Dobavkis { get; set; }
    }

   
}