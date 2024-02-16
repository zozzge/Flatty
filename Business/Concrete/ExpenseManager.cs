using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
    public class ExpenseManager : IExpenseService
    {
        private readonly FlattyContext _context;
        IExpenseDal _expenseDal;
        private object filter;
        IGroupDal _groupDal;
        IUserDal _userDal;

        public ExpenseManager(IExpenseDal expenseDal)
        {
            _expenseDal = expenseDal;
        }

        public IResults AddExpense(Expense expense)
        {
            _expenseDal.Add(expense);

            if (expense.Amount < 6)
            {
                return new FailureResult(Messages.ExpenseAddFail);
            }

            return new SuccessResult(Messages.ExpenseAddSuccess);
        }

        public IResults DeleteExpense(Expense expense)
        {
            _expenseDal.Delete(expense);
            if (expense.Amount < 6)
            {
                return new FailureResult(Messages.ExpenseDeleteFail);
            }

            return new SuccessResult(Messages.ExpenseDeleteFail);
        }

        

        public IDataResult<List<Expense>> GetAll()
        {
            return new SuccessDataResult<List<Expense>>(_expenseDal.GetAll(),"Expenses listed.");
        }

        public void UpdateExpense(Expense expense)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Expense> GetById(int expenseId)
        {
               return new SuccessDataResult<Expense>(_expenseDal.Get(e => e.Id == expenseId));
        }

        void IExpenseService.GetExpenseCount(int expenseId)
        {
            _expenseDal.GetCountById(expenseId);
        }

        IResults IExpenseService.UpdateExpense(Expense expense)
        {
            throw new NotImplementedException();
        }

        public void GetExpenseBalance(int expenseId,int groupId,int payerId)
        {
            int memberCount = _groupDal.GetCountById(groupId);
            
        }
    }
}
