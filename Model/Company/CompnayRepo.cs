using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    internal class CompanyRepo:IRepo<Company>
    {
        PharmacyDB db;
        public CompanyRepo()
        {
            db = new PharmacyDB();
        }

        public List<Company> GetAll()
        {
            var Companyes = db.Company.ToList();
            return Companyes;
        }
        public Company GetById(int id)
        {
            var Company = db.Company.Find(id);
            return Company;
        }
        public void DeleteById(int id)
        {
            Company Company = db.Company.Find(id);
            Company.IsDeleted = true;
            db.SaveChanges();
        }
        public void Add(Company Item)
        {
            db.Company.Add(Item);
            db.SaveChanges();
        }

        public void Update(Company Item)
        {
            db.Company.AddOrUpdate(Item);
            db.SaveChanges();
        }
        public void Delete(Company _Item)
        {
            Company brnach = db.Company.Find(_Item.Id);
            brnach.IsDeleted = true;
            db.SaveChanges();
        }
    }
}
