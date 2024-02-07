using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResults AddUser(User user);
        IResults UpdateUser(User user);
        IResults DeleteUser(User user);
        IDataResult<List<User>> GetByUserName(string userName);
        IDataResult<User> GetById(int id);
         
    }
}
