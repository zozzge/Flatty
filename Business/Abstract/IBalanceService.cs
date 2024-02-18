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
        Balance GetByUserIdAndGroupId(int userId, int groupId);
        void IncreaseBalance(int userId, int groupId, decimal amount);
        void DecreaseBalance(int userId, int groupId, decimal amount);



    }
}
