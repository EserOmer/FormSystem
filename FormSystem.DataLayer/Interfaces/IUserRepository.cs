using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.DataLayer.Interfaces
{
    public interface IUserRepository:IRepository<ENTUser>
    {
        public ENTUser GetByMail(Expression<Func<ENTUser, bool>> filter);

    }
}
