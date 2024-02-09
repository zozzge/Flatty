using Entities.Concrete;
using System;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);

    }
}
