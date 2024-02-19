using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Balance:IEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }


    }
}
