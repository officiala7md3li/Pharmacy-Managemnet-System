using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    internal class PatientPaymentRepo:IRepo<PatientPayment>
    {
        PharmacyDB db;
        public PatientPaymentRepo()
        {
            db = new PharmacyDB();
        }

        public List<PatientPayment> GetAll()
        {
            var PatientPaymentes = db.PatientPayment.ToList();
            return PatientPaymentes;
        }
        public PatientPayment GetById(int id)
        {
            var PatientPayment = db.PatientPayment.Find(id);
            return PatientPayment;
        }
        public void DeleteById(int id)
        {
            PatientPayment PatientPayment = db.PatientPayment.Find(id);
            db.PatientPayment.Remove(PatientPayment);
            db.SaveChanges();
        }
        public void Add(PatientPayment Item)
        {
            db.PatientPayment.Add(Item);
            db.SaveChanges();
        }

        public void Update(PatientPayment Item)
        {
            db.PatientPayment.AddOrUpdate(Item);
            db.SaveChanges();
        }
        public void Delete(PatientPayment _Item)
        {
            PatientPayment brnach = db.PatientPayment.Find(_Item.Id);
            db.PatientPayment.Remove(brnach);
            db.SaveChanges();
        }
    }
}
