using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    internal class DrugConcentrationPriceRepo:IRepo<DrugConcentrationPrice>
    {
        PharmacyDB db;
        public DrugConcentrationPriceRepo()
        {
            db = new PharmacyDB();
        }

        public List<DrugConcentrationPrice> GetAll()
        {
            var DrugConcentrationPricees = db.DrugConcentrationPrice.ToList();
            return DrugConcentrationPricees;
        }
        public DrugConcentrationPrice GetById(int id)
        {
            var DrugConcentrationPrice = db.DrugConcentrationPrice.Find(id);
            return DrugConcentrationPrice;
        }
        public void DeleteById(int id)
        {
            DrugConcentrationPrice DrugConcentrationPrice = db.DrugConcentrationPrice.Find(id);
            db.DrugConcentrationPrice.Remove(DrugConcentrationPrice);
            db.SaveChanges();
        }
        public void Add(DrugConcentrationPrice Item)
        {
            db.DrugConcentrationPrice.Add(Item);
            db.SaveChanges();
        }

        public void Update(DrugConcentrationPrice Item)
        {
            db.DrugConcentrationPrice.AddOrUpdate(Item);
            db.SaveChanges();
        }
        public void Delete(DrugConcentrationPrice _Item)
        {
            DrugConcentrationPrice brnach = db.DrugConcentrationPrice.Find(_Item.Id);
            db.DrugConcentrationPrice.Remove(brnach);
            db.SaveChanges();
        }
    }
}
