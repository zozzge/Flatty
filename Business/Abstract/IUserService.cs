﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        List<User> GetByUserName(string userName);
    }
}