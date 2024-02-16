using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GroupUserManager : IGroupUserService
    {

        private readonly FlattyContext _context;

        IGroupUserDal _groupUserDal;
        IGroupDal _groupDal; //?
        IExpenseDal _expenseDal;

        //public GroupUserManager(IGroupUserDal memberBalanceDal) 
        //{
        //    _groupUserDal = groupUserDal;

        //}
        //public void AddMemberBalance(GroupUser memberBalance)
        //{
        //    _groupUserDal.Add(groupUser);
        //}

        //public void CalculateMemberBalance(int groupId)
        //{
        //     _expenseDal.GetById();
        //}

        //public void DeleteMemberBalance(GroupUser groupUser)
        //{
        //    _groupUserDal.Delete(groupUser);
        //}

        //public List<groupUser> GetAll()
        //{
        //    return _groupUserDal.GetAll();
        //}

        //public List<GroupUser> GetById()
        //{
        //    return _context.GroupUser.ToList();
        //}

        //public void UpdateGroupUser(GroupUser groupUser)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
