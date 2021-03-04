using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.DataLayer
{
    public interface IRepository<T> where T : class, IEntity
    {
        public List<T> GetAll(Expression<Func<T, bool>> filter = null);
        public T Get(Expression<Func<T, bool>> filter);
        void Add(T name);
        void Update(T name);
        public void Delete(T entity);


    }
}
