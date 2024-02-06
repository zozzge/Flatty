using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IExpenseService
    {
        List<Expense> GetAll();
        void AddExpense(Expense expense);
        void UpdateExpense(Expense expense);
        void DeleteExpense(Expense expense);
        void GetExpenseCount(int expenseId);
        List<Expense> GetById(int expenseId);
    }
}
