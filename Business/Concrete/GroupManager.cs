using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GroupManager:IGroupService
    {

         private readonly FlattyContext _context;
        IGroupDal _groupDal;
        private object filter;

        public GroupManager(IGroupDal groupDal) 
        {
            _groupDal = groupDal;
        }

        public void AddGroup(Group group)
        {
            _groupDal.Add(group);
        }

        public void DeleteGroup(Group group)
        {
            _groupDal.Delete(group);
        }

        public List<Group> GetAll()
        {
            return _groupDal.GetAll();  
        }

        public List<Group> GetById(int groupId)
        {
            if (filter != null)
            {
                return _context.Groups.Where(e => e.Id == groupId).ToList();
            }
            else
            {
                return _context.Groups.ToList();
            }
        }

        public List<Group> GetByGroupName(string groupName)
        {
            return _groupDal.GetAll(n=>n.Name==groupName);
        }


        public void UpdateGroup(Group group)
        {
            throw new NotImplementedException();
        }
    }
}
