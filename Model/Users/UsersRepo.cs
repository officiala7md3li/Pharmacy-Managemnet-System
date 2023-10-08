using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managemnet_System.Model
{
    internal class UserRepo:IRepo<User>
    {
        PharmacyDB db;
        public UserRepo()
        {
            db = new PharmacyDB();
        }
        
        public List<User> GetAll()
        {
            
            var Useres = db.User.ToList();
            return Useres;
        }
        public User GetById(int id)
        {
            var User = db.User.Find(id);
            return User;
        }
        public void DeleteById(int id)
        {
            User User = db.User.Find(id);
            User.IsDeleted = true;
            db.SaveChanges();
        }
        public void Add(User Item)
        {
            db.User.Add(Item);
            db.SaveChanges();
        }

        public void Update(User Item)
        {
            db.User.AddOrUpdate(Item);
            db.SaveChanges();
        }
        public void Delete(User _Item)
        {
            User brnach = db.User.Find(_Item.Id);
            brnach.IsDeleted = true;
            db.SaveChanges();
        }
        public User ValidateUser(string _userName , string _password)
        {
            if (IsEmpty())
            {
                throw new Exception("No Record in Database");
            }
            var user = (from u in db.User
                        where u.UserName == _userName && u.Password == _password
                        select u).FirstOrDefault();
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new Exception("User Not Found");
            }
        }
        public bool IsEmpty()
        {
            return !db.User.Any(); //if true table is empty
        }
        public User GetByRecoveryWord(string _recoverWord)
        {
            return db.User.Select(x=>x).Where(x=>x.RecoverWord == _recoverWord).FirstOrDefault();
        }
        public void ChangePassword(int _id, string _password)
        {
            var user = db.User.Find(_id);
            user.Password = _password;
            db.SaveChanges();
        }

    }
}
