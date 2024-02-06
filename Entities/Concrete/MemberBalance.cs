using Entities.Abstract;
using Core.Entities;

namespace Entities.Concrete
{
    public class MemberBalance:IEntity
    {
        public int Id {  get; set; }
        public Group Group { get; set; }
        public User Debtor { get; set; }
        public User Creditor { get; set; }
        public decimal Balance { get; set; }


    }
}
