using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.DataLayer
{
    public class Repository<T> : IRepository<T> where T :class
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

        public List<T> GetAll()
        {
            return _formContext.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return _formContext.Set<T>().Find(id);
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
