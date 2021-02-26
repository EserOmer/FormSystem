using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.DataLayer.Repositories
{
    public class UserRepository : Repository<ENTUser>
    {
        private readonly FormContext _formContext;
        public UserRepository(FormContext context) : base(context)
        {
            _formContext = context;
        }
        public ENTUser GetByMail(string mail)
        {
            return _formContext.USER.SingleOrDefault(u => u.EMAIL == mail);
        }
        
    }
}
