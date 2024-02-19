using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBalanceService
    {
        
        public void IncreaseBalance(int id, decimal amount);
        public void DecreaseBalance(int id, decimal amount);

    }
}
