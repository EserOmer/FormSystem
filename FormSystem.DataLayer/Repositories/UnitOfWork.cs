using FormSystem.DataLayer.Interfaces;
using FormSystem.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FormContext _formContext;
        public UnitOfWork()
        {
            _formContext = new FormContext();
        }
        public IUserRepository UserRepository
        {
            get { return new UserRepository(_formContext); }
        }

        public void Dispose()
        {
            _formContext.Dispose();
        }

    }
}
