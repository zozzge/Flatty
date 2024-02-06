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
    public class ExpenseManager : IExpenseService
    {
        private readonly FlattyContext _context;
        IExpenseDal _expenseDal;
        private object filter;

        public ExpenseManager(IExpenseDal expenseDal)
        {
            _expenseDal = expenseDal;
        }

        public void AddExpense(Expense expense)
        {
            _expenseDal.Add(expense);
        }

        public void DeleteExpense(Expense expense)
        {
            _expenseDal.Delete(expense);
        }

        public List<Expense> GetAll()
        {
            return _expenseDal.GetAll();
        }

        public List<Expense> GetById(int expenseId)
        {
            if (filter != null)
            {
                return _context.Expenses.Where(e => e.Id == expenseId).ToList();
            }
            else
            {
                return _context.Expenses.ToList();
            }
        }

        /*void GetExpenseCount(int expenseId)
        {
            _expenseDal.GetCountById(expenseId);
        }*/

        public void UpdateExpense(Expense expense)
        {
            throw new NotImplementedException();
        }

        void IExpenseService.GetExpenseCount(int expenseId)
        {
            _expenseDal.GetCountById(expenseId);
        }

        
    }
}
