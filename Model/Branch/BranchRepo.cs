using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Pharmacy_Managemnet_System.Model
{
    public class BranchRepo:IRepo<Branch>
    {
        PharmacyDB db;
        public BranchRepo()
        {
            db = new PharmacyDB();
        }
        
        public List<Branch> GetAll()
        {
            var Branches = db.Branch.ToList();
            return Branches;
        }
        public Branch GetById(int id)
        {
            var Branch = db.Branch.Find(id);
            return Branch;
        }
        public void DeleteById(int id)
        {
            Branch branch = db.Branch.Find(id);
            branch.IsDeleted = true;
            db.SaveChanges();
        }
        public void Add(Branch Item)
        {
            db.Branch.Add(Item);
            db.SaveChanges();
        }

        public void Update(Branch Item)
        {
            db.Branch.AddOrUpdate(Item);
            db.SaveChanges();
        }
        public void Delete(Branch _Item)
        {
            Branch brnach = db.Branch.Find(_Item.Id);
            brnach.IsDeleted = true;
            db.SaveChanges();
        }
    }
}
