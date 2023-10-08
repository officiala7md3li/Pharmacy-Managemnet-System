using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    internal class DoctorRepo:IRepo<Doctor>
    {
        PharmacyDB db;
        public DoctorRepo()
        {
            db = new PharmacyDB();
        }

        public List<Doctor> GetAll()
        {
            var Doctores = db.Doctor.ToList();
            return Doctores;
        }
        public Doctor GetById(int id)
        {
            var Doctor = db.Doctor.Find(id);
            return Doctor;
        }
        public void DeleteById(int id)
        {
            Doctor Doctor = db.Doctor.Find(id);
            Doctor.IsDeleted = true;
            db.SaveChanges();
        }
        public void Add(Doctor Item)
        {
            db.Doctor.Add(Item);
            db.SaveChanges();
        }

        public void Update(Doctor Item)
        {
            db.Doctor.AddOrUpdate(Item);
            db.SaveChanges();
        }
        public void Delete(Doctor _Item)
        {
            Doctor brnach = db.Doctor.Find(_Item.Id);
            brnach.IsDeleted = true;
            db.SaveChanges();
        }
    }
}
