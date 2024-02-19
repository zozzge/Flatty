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

        public void IncreaseBalance(int id,decimal amount)
        {
            var balance = _balanceDal.Get(b => b.Id == id );
            balance.Amount += amount;
            _balanceDal.Update(balance);
            
        }

        public void DecreaseBalance(int id,decimal amount)
        {
            var balance = _balanceDal.Get(b => b.Id == id);
            balance.Amount -= amount;
            _balanceDal.Update(balance);
            
        }
    }
}
