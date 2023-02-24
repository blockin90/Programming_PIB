using System;
using System.Data.Entity;
using System.Linq;

namespace Part3_Sample.Model
{
    public class UniversityModel : DbContext
    {
        private UniversityModel()
            : base("name=UniversityModel")
        {
        }
        private static UniversityModel _instance;
        public static UniversityModel Instance
        { 
            get
            {
                if(_instance == null) {
                    _instance = new UniversityModel();
                }
                return _instance;
            }
        }

        static UniversityModel()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}