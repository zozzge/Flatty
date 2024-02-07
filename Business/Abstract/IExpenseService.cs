using Core.Utilities.Results;
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
        IDataResult<List<Expense>> GetAll();
        IResults AddExpense(Expense expense);
        IResults UpdateExpense(Expense expense);
        IResults DeleteExpense(Expense expense);
        void GetExpenseCount(int expenseId);
        IDataResult<Expense> GetById(int expenseId);
    }
}
