using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    internal class SupplierRepo:IRepo<Supplier>
    {
        PharmacyDB db;
        public SupplierRepo()
        {
            db = new PharmacyDB();
        }

        public List<Supplier> GetAll()
        {
            var Supplieres = db.Supplier.ToList();
            return Supplieres;
        }
        public Supplier GetById(int id)
        {
            var Supplier = db.Supplier.Find(id);
            return Supplier;
        }
        public void DeleteById(int id)
        {
            Supplier Supplier = db.Supplier.Find(id);
            Supplier.IsDeleted = true;
            db.SaveChanges();
        }
        public void Add(Supplier Item)
        {
            db.Supplier.Add(Item);
            db.SaveChanges();
        }

        public void Update(Supplier Item)
        {
            db.Supplier.AddOrUpdate(Item);
            db.SaveChanges();
        }
        public void Delete(Supplier _Item)
        {
            Supplier brnach = db.Supplier.Find(_Item.Id);
            brnach.IsDeleted = true;
            db.SaveChanges();
        }
    }
}
