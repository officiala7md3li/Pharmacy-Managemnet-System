using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    internal class SupplierPaymentRepo:IRepo<SupplierPayment>
    {
        PharmacyDB db;
        public SupplierPaymentRepo()
        {
            db = new PharmacyDB();
        }

        public List<SupplierPayment> GetAll()
        {
            var SupplierPaymentes = db.SupplierPayment.ToList();
            return SupplierPaymentes;
        }
        public SupplierPayment GetById(int id)
        {
            var SupplierPayment = db.SupplierPayment.Find(id);
            return SupplierPayment;
        }
        public void DeleteById(int id)
        {
            SupplierPayment SupplierPayment = db.SupplierPayment.Find(id);
            db.SupplierPayment.Remove(SupplierPayment);
            db.SaveChanges();
        }
        public void Add(SupplierPayment Item)
        {
            db.SupplierPayment.Add(Item);
            db.SaveChanges();
        }

        public void Update(SupplierPayment Item)
        {
            db.SupplierPayment.AddOrUpdate(Item);
            db.SaveChanges();
        }
        public void Delete(SupplierPayment _Item)
        {
            SupplierPayment brnach = db.SupplierPayment.Find(_Item.Id);
            db.SupplierPayment.Remove(brnach);
            db.SaveChanges();
        }
    }
}
