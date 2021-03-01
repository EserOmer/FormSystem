using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.DataLayer.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetByID(Expression<Func<T, bool>> filter);
        void Add(T name);
        void Update(T name);
        void Save();
    }
}
