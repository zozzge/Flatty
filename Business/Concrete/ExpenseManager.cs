using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ExpenseManager : IExpenseService
    {
        private readonly FlattyContext _context;
        private readonly BalanceManager balanceManager;
        private readonly GroupManager groupManager;
        IExpenseDal _expenseDal;
        private object filter;
        IGroupDal _groupDal;
        IUserDal _userDal;
        IBalanceDal _balanceDal;

        public ExpenseManager(IExpenseDal expenseDal)
        {
            _expenseDal = expenseDal;
            
        }
        

        public IResults AddExpense(Expense expense,int expenseAdderUserId)
        {
            var amount = expense.Amount;
            var groupMembersResult = this.groupManager.GetMembers(expense.GroupId);

            var groupMembers = groupMembersResult.Data
                             .Where(m => m.Id != expenseAdderUserId)
                             .ToList();


            int memberCount = groupMembers.Count();
            decimal amountPerMember = expense.Amount / memberCount;
            decimal amountToUser = amount - (amountPerMember*memberCount);

            foreach (var member in groupMembers)
            {
                if (member.Id == expense.PaidById) // Credit
                {
                    this.balanceManager.IncreaseBalance(expense.GroupId,amountToUser);
                }
                else // Debt
                {
                    this.balanceManager.DecreaseBalance(expense.GroupId,amountPerMember);
                }
            }

            return new SuccessResult(Messages.ExpenseAddSuccess);
        }

        public IResults DeleteExpense(Expense expense)
        {
            _expenseDal.Delete(expense);
            return new SuccessResult(Messages.ExpenseDeleteFail);
        }

        

        public IDataResult<List<Expense>> GetAll()
        {
            return new SuccessDataResult<List<Expense>>(_expenseDal.GetAll(),"Expenses listed.");
        }

        public void UpdateExpense(Expense expense)
        {
            _expenseDal.Update(expense);
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

        //public void GetExpenseBalance(decimal amount, User userAddingExpense, List<User> groupMembers)
        //{
        //    int totalCount = groupMembers.Count;
        //    int memberCount = totalCount - 1;
        //    decimal sharePerMember=amount/memberCount;

        //    foreach(var member in groupMembers)
        //    {
        //        if (member == userAddingExpense)
        //            continue;
        //    }
        //}
    }
}
