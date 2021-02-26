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
        public readonly UserRepository _userRepository;
       
        public UnitOfWork()
        {
            _formContext = new FormContext();
            _userRepository = new UserRepository(_formContext);
        }
        public void Dispose()
        {
            _formContext.Dispose();
        }

    }
}
