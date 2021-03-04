using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using FormSystem.BusinessLayer;
using FormSystem.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace FormSystem.BusinessLayer
{
    public class UserService : IUserService
    {
        IUserRepository _userDal;
        public UserService(IUserRepository userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(ENTUser user)
        {
            _userDal.Add(user);
            return new SuccessResult("Ekleme Basarili");
        }

        public IDataResult<List<ENTUser>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<ENTUser>>("Sistem Bakimda");
            }
            return new SuccessDataResult<List<ENTUser>>(_userDal.GetAll(), "Listeleme Basarili");
        }

        public IDataResult<ENTUser> GetById(int id)
        {
            return new SuccessDataResult<ENTUser>(_userDal.Get(u => u.ID == id));
        }

        public IDataResult<ENTUser> GetByMail(string mail)
        {
            return new SuccessDataResult<ENTUser>(_userDal.Get(u => u.EMAIL == mail));
        }
    }
}
