using FormSystem.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.DataLayer.Repositories
{
    public class UserRepository : Repository<ENTUser>,IUserRepository
    {
        private readonly FormContext _formContext;
        public UserRepository(FormContext context) : base(context)
        {
            _formContext = context;
        }
        public ENTUser GetByMail(Expression<Func<ENTUser, bool>> filter)
        {
            return _formContext.Set<ENTUser>().SingleOrDefault(filter);
        }
    }
}
