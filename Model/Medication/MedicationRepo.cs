using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    internal class MedicationRepo:IRepo<Medication>
    {
        PharmacyDB db;
        public MedicationRepo()
        {
            db = new PharmacyDB();
        }

        public List<Medication> GetAll()
        {
            var Medicationes = db.Medication.ToList();
            return Medicationes;
        }
        public Medication GetById(int id)
        {
            var Medication = db.Medication.Find(id);
            return Medication;
        }
        public void DeleteById(int id)
        {
            Medication Medication = db.Medication.Find(id);
            Medication.IsDeleted = true;
            db.SaveChanges();
        }
        public void Add(Medication Item)
        {
            db.Medication.Add(Item);
            db.SaveChanges();
        }

        public void Update(Medication Item)
        {
            db.Medication.AddOrUpdate(Item);
            db.SaveChanges();
        }
        public void Delete(Medication _Item)
        {
            Medication brnach = db.Medication.Find(_Item.Id);
            brnach.IsDeleted = true;
            db.SaveChanges();
        }
    }
}
