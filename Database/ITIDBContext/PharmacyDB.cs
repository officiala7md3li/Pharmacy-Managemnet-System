using Pharmacy_Managemnet_System.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System
{
    public class PharmacyDB:DbContext
    {
        public PharmacyDB() : base("name=ITIPharmacyConnection")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
           .Property(p => p.Photo)
           .HasColumnType("image");
            modelBuilder.Entity<Medication>()
            .Property(p => p.Photo)
            .HasColumnType("image");
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<DoctorSpecialization> DoctorSpecialization { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public DbSet<InvoiceHeader> InvoiceHeader {  get; set; }
        public DbSet<DrugConcentrationPrice> DrugConcentrationPrice { get; set; }
        public DbSet<Medication> Medication { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<PatientPayment> PatientPayment { get; set; }
        public DbSet<Prescription> Prescription {  get; set; }
        public DbSet<Supplier> Supplier {  get; set; }
        public DbSet<SupplierPayment> SupplierPayment {  get; set; }
        public DbSet<User> User {  get; set; }
    }
}
