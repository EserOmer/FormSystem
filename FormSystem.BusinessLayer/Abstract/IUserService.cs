using Core.Utilities.Results;
using FormSystem.BusinessLayer;
using FormSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.BusinessLayer
{
    public interface IUserService
    {
        IDataResult<List<ENTUser>> GetAll();
        IDataResult<ENTUser> GetById(int id);
        IDataResult<ENTUser> GetByMail(string mail);
        IResult Add(ENTUser user);
    }
}
