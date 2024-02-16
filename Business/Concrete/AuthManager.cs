using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.DTOs;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                EMail = userForRegisterDto.Email,
                FirstName = userForRegisterDto.Name,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(new User
            {
                EMail = userForRegisterDto.Email,
                FirstName = userForRegisterDto.Name,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            });
            return new SuccessDataResult<User>(user, "User Signed Up");
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new FailDataResult<User>("User Not Found");
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new FailDataResult<User>("Password Error");
            }

            return new SuccessDataResult<User>(userToCheck, "Successfull Log In");
        }

        public IResults UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new FailureResult("User Already Exists");
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "Access Token Created");
        }
    }
}
