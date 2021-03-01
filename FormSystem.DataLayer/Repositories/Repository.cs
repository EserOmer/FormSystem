using FormSystem.DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.DataLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly FormContext _formContext;


        public Repository(FormContext context)
        {
            _formContext = context;
        }
        public void Add(T entity)
        {
            _formContext.Set<T>().Add(entity);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _formContext.Set<T>().ToList() : _formContext.Set<T>().Where(filter).ToList();
        }
        public T GetByID(Expression<Func<T, bool>> filter)
        {
            return _formContext.Set<T>().SingleOrDefault(filter);
        }

        public void Save()
        {
            _formContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _formContext.Set<T>().Attach(entity);
            _formContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
