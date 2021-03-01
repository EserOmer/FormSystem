using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormSystem.DataLayer;
using FormSystem.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FormSystem.BusinessLayer
{
    public class User
    {
        public List<ENTUser> GetAll()
        {
            using (var uow=new UnitOfWork())
            {
                return uow.UserRepository.GetAll();
            }
        }
        public ENTUser GetById(int id)
        {
            using (var uow = new UnitOfWork())
            {
                return uow.UserRepository.GetByID(u=>u.ID==id);
            }
        }
    }
}
