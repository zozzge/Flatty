using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal) 
        { 
            _userDal = userDal;
        }
        public IResults Add(User user)
        {
            _userDal.Add(user);

            if (user.Name.Length<2)
            {
                return new FailureResult("User name must be at least 2 characters.");
            }

            return new Results(true, "User Added");
        }

        public void DeleteUser(User user)
        {
            _userDal.Delete(user);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();   
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetByUserName(string userName)
        {
            return _userDal.GetAll(n=>n.Name==userName);
        }
    }
}
