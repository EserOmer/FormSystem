using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.DataLayer
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetByID(int id);
        void Add(T name);
        void Update(T name);
        void Save(); 
    }
}
