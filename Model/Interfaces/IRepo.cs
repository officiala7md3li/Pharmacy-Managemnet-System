using System.Collections.Generic;

namespace Pharmacy_Managemnet_System.Model
{
    public interface IRepo<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void DeleteById(int id);
        void Add(T Item);
        void Update(T Item);
        void Delete(T _Item);
       
    }
}