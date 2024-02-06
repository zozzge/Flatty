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
        List<Group> GetAll();
        void AddGroup(Group group);
        void UpdateGroup(Group group);
        void DeleteGroup(Group group);
        List<Group> GetByGroupName(string groupName);
        List<Group> GetById(int groupId);
    }
}
