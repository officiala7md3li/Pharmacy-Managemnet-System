using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    internal class PatientRepo:IRepo<Patient>
    {
        PharmacyDB db;
        public PatientRepo()
        {
            db = new PharmacyDB();
        }

        public List<Patient> GetAll()
        {
            var Patientes = db.Patient.ToList();
            return Patientes;
        }
        public Patient GetById(int id)
        {
            var Patient = db.Patient.Find(id);
            return Patient;
        }
        public void DeleteById(int id)
        {
            Patient Patient = db.Patient.Find(id);
            Patient.IsDeleted = true;
            db.SaveChanges();
        }
        public void Add(Patient Item)
        {
            db.Patient.Add(Item);
            db.SaveChanges();
        }

        public void Update(Patient Item)
        {
            db.Patient.AddOrUpdate(Item);
            db.SaveChanges();
        }
        public void Delete(Patient _Item)
        {
            Patient brnach = db.Patient.Find(_Item.Id);
            brnach.IsDeleted = true;
            db.SaveChanges();
        }
    }
}
