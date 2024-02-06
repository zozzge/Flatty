using Entities.Abstract;
using System;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Expense:IEntity
    {
        public int Id { get; set; }
        public int PaidById { get; set; }
        public int PaidOnId { get; set; }
        public decimal Amount { get; set; }
        public DateTime EndDate { get; set; }
        
    }

    public enum ExpenseType
    {
        Debt,
        Credit
    }
}
