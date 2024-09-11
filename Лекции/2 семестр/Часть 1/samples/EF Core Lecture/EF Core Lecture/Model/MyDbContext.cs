using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Lecture.Model
{
    using Microsoft.EntityFrameworkCore;

    internal class MyDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MyTestDb;Trusted_Connection=True; TrustServerCertificate=True;");
        }
    }
}
