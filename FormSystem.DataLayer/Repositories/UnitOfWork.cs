using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.DataLayer
{
    public class UnitOfWork 
    {
        protected readonly FormContext _formContext;
        public UnitOfWork(FormContext formContext)
        {
            _formContext = formContext;
        }
        public void Dispose()
        {
            _formContext.Dispose();
        }

    }
}
