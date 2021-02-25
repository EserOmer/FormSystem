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
        public List<ENTUser> GetAllUser()
        {
            using (FormContext formContext = new FormContext())
            {
                return formContext.USER.ToList();
            }

        }
    }
}
