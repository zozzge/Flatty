using Entities.Concrete;
using System;
using Core.DataAccess;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IExpenseDal:IEntityRepository<Expense>
    {
        

        
    }
}
