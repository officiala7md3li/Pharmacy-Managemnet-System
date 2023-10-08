using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model.Invoice
{
    internal class InvoiceHeaderRepo:IRepo<InvoiceHeader>
    {
        PharmacyDB db;
        public InvoiceHeaderRepo()
        {
            db = new PharmacyDB();
        }

        public List<InvoiceHeader> GetAll()
        {
            var InvoiceHeaderes = db.InvoiceHeader.ToList();
            return InvoiceHeaderes;
        }
        public InvoiceHeader GetById(int id)
        {
            var InvoiceHeader = db.InvoiceHeader.Find(id);
            return InvoiceHeader;
        }
        public void DeleteById(int id)
        {
            InvoiceHeader InvoiceHeader = db.InvoiceHeader.Find(id);
            InvoiceHeader.IsDeleted = true;
            db.SaveChanges();
        }
        public void Add(InvoiceHeader Item)
        {
            db.InvoiceHeader.Add(Item);
            db.SaveChanges();
        }

        public void Update(InvoiceHeader Item)
        {
            db.InvoiceHeader.AddOrUpdate(Item);
            db.SaveChanges();
        }
        public void Delete(InvoiceHeader _Item)
        {
            InvoiceHeader brnach = db.InvoiceHeader.Find(_Item.Id);
            brnach.IsDeleted = true;
            db.SaveChanges();
        }
    }
}
