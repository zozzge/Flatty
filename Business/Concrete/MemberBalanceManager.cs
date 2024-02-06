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
    public class MemberBalanceManager : IMemberBalanceService
    {

        private readonly FlattyContext _context;

        IMemberBalanceDal _memberBalanceDal;
        IGroupDal _groupDal; //?
        IExpenseDal _expenseDal;
        public MemberBalanceManager(IMemberBalanceDal memberBalanceDal) 
        {
            _memberBalanceDal = memberBalanceDal;

        }
        public void AddMemberBalance(MemberBalance memberBalance)
        {
            _memberBalanceDal.Add(memberBalance);
        }

        public void CalculateMemberBalance(int groupId)
        {
             _expenseDal.GetById();
        }

        public void DeleteMemberBalance(MemberBalance memberBalance)
        {
            _memberBalanceDal.Delete(memberBalance);
        }

        public List<MemberBalance> GetAll()
        {
            return _memberBalanceDal.GetAll();
        }

        public List<MemberBalance> GetById()
        {
            return _context.MemberBalances.ToList();
        }

        public void UpdateMemberBalance(MemberBalance memberBalance)
        {
            throw new NotImplementedException();
        }
    }
}
