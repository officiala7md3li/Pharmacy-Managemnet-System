using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    internal class DoctorSpecializationRepo:IRepo<DoctorSpecialization>
    {
        PharmacyDB db;
        public DoctorSpecializationRepo()
        {
            db = new PharmacyDB();
        }

        public List<DoctorSpecialization> GetAll()
        {
            var DoctorSpecializationes = db.DoctorSpecialization.ToList();
            return DoctorSpecializationes;
        }
        public DoctorSpecialization GetById(int id)
        {
            var DoctorSpecialization = db.DoctorSpecialization.Find(id);
            return DoctorSpecialization;
        }
        public void DeleteById(int id)
        {
            DoctorSpecialization DoctorSpecialization = db.DoctorSpecialization.Find(id);
            db.DoctorSpecialization.Remove(DoctorSpecialization);
            db.SaveChanges();
        }
        public void Add(DoctorSpecialization Item)
        {
            db.DoctorSpecialization.Add(Item);
            db.SaveChanges();
        }

        public void Update(DoctorSpecialization Item)
        {
            db.DoctorSpecialization.AddOrUpdate(Item);
            db.SaveChanges();
        }
        public void Delete(DoctorSpecialization _Item)
        {
            DoctorSpecialization brnach = db.DoctorSpecialization.Find(_Item.Id);
            db.DoctorSpecialization.Remove(brnach);
            db.SaveChanges();
        }
    }
}
