using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    internal class PrescriptionRepo:IRepo<Prescription>
    {
        PharmacyDB db;
        public PrescriptionRepo()
        {
            db = new PharmacyDB();
        }

        public List<Prescription> GetAll()
        {
            var Prescriptiones = db.Prescription.ToList();
            return Prescriptiones;
        }
        public Prescription GetById(int id)
        {
            var Prescription = db.Prescription.Find(id);
            return Prescription;
        }
        public void DeleteById(int id)
        {
            Prescription Prescription = db.Prescription.Find(id);
            Prescription.IsDeleted = true;
            db.SaveChanges();
        }
        public void Add(Prescription Item)
        {
            db.Prescription.Add(Item);
            db.SaveChanges();
        }

        public void Update(Prescription Item)
        {
            db.Prescription.AddOrUpdate(Item);
            db.SaveChanges();
        }
        public void Delete(Prescription _Item)
        {
            Prescription brnach = db.Prescription.Find(_Item.Id);
            brnach.IsDeleted = true;
            db.SaveChanges();
        }
    }
}
