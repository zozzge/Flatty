﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGroupService
    {
        IDataResult<List<Group>> GetAll();
        IResults AddGroup(Group group);
        IResults UpdateGroup(Group group);
        IResults DeleteGroup(Group group);
        IDataResult<List<Group>> GetByGroupName(string groupName);
        IDataResult<Group> GetById(int groupId);
    }
}
