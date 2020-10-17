using BL.BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class MedicineContext : DbContext
    {
        public MedicineContext() : base("MedicineContext")
        {


        }

        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Ingredient> Ingrediientss { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}


