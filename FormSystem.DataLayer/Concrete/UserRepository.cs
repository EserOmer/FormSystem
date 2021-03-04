using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.DataLayer
{
    public class UserRepository : Repository<ENTUser,FormContext>,IUserRepository
    {
    }
}
