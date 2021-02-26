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
        private readonly UserRepository _userRepository;
       
        public UnitOfWork(FormContext formContext, UserRepository userRepository)
        {
            _formContext = formContext;
            _userRepository = userRepository;
        }
        public void Dispose()
        {
            _formContext.Dispose();
        }

    }
}
