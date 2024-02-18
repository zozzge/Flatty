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
    public class BalanceManager : IBalanceService
    {

        IBalanceDal _balanceDal;
        private readonly FlattyContext _context;

        public BalanceManager(FlattyContext context)
        {
            _context = context;
        }

        public Balance GetByUserIdAndGroupId(int userId, int groupId)
        {
            return _context.Balances.FirstOrDefault(b => b.UserId == userId && b.GroupId == groupId);
        }
        public void DecreaseBalance(int userId, int groupId, decimal amount)
        {
            var balance = _balanceDal.GetByUserIdAndGroupId(userId, groupId);
            if (balance != null)
            {
                balance.Amount -= amount;
                _balanceDal.Update(balance);
            }
            else
            {
                // Handle error: Balance record not found
            }
        }

        public void IncreaseBalance(int userId, int groupId, decimal amount)
        {
            var balance = _balanceDal.GetByUserIdAndGroupId(userId, groupId);
            if (balance != null)
            {
                balance.Amount += amount;
                _balanceDal.Update(balance);
            }
            else
            {
                // Create a new balance record if it doesn't exist
                var newBalance = new Balance
                {
                    UserId = userId,
                    GroupId = groupId,
                    Amount = amount
                };
                _balanceDal.Add(newBalance);
            }
        }
    }
}
