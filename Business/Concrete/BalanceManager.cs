using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResults IncreaseBalance(Balance balance)
        {
            var amount= balance.Amount;
            balance.Amount += amount;
            _balanceDal.Update(balance);
            return new SuccessResult(Messages.BalanceUpdated);
        }

        public IResults DecreaseBalance(Balance balance)
        {
            var amount = balance.Amount;
            balance.Amount -= amount;
            _balanceDal.Update(balance);
            return new SuccessResult(Messages.BalanceUpdated);
        }
    }
}
