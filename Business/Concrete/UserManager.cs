using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
        [ValidationAspect(typeof(UserValidator))]
        public IResults AddUser(User user)
        {
            
            if (CheckIfUserNameIsCorrect(user.Name).IsSuccess)
            {
                if (CheckIfUserNameAlreadyExists(user.Name).IsSuccess)
                {
                    _userDal.Add(user);
                    return new SuccessResult(Messages.UserAddSuccess);
                }
                                
            }
            return new FailureResult(Messages.UserAddFail);
        }

        public IResults DeleteUser(User user)
        {
            _userDal.Delete(user);
            if (user.Name.Length < 6)
            {
                return new FailureResult(Messages.UserDeleteFail);
            }

            return new SuccessResult(Messages.UserDeleteFail);


        }

        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour==24)
            {
                return new FailDataResult<List<User>>();
            }
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),"Users listed.");


        }

        public IDataResult<User> GetById(int id)
        {
            var user = _userDal.Get(u => u.Id == id);

            // Check if the user with the specified ID exists
            if (user == null)
            {
                return new FailDataResult<User>(null, Messages.UserNotFound);
            }

            // Return the user data wrapped in a success result
            return new SuccessDataResult<User>(user, Messages.UserFound);
        }

        public IDataResult<List<User>> GetByUserName(string userName)
        {
            return new SuccessDataResult<List<User>> (_userDal.GetAll(n=>n.Name==userName));
        }

        public IResults UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        private IResults CheckIfUserNameIsCorrect(string userName)
        {
            var result=_userDal.GetAll(u=>u.Name==userName);
            if(userName.Length<=5)
            {
                return new FailureResult(Messages.UserNameInvalid);
            }
            return new SuccessResult();
        }

        private IResults CheckIfUserNameAlreadyExists(string userName)
        {
            var result = _userDal.GetAll(u=>u.Name==userName);
            if (userName.Any())
            {
                return new FailureResult(Messages.UserNameAlreadyExists);
            }
            return new SuccessResult(); 
        }
    }
}
