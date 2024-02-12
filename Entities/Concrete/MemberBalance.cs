using Entities.Abstract;
using Core.Entities;

namespace Entities.Concrete
{
    public class MemberBalance:IEntity
    {
        public int Id {  get; set; }
        public Group Group { get; set; }
        public int DebtorId { get; set; }
        public int CreditorId { get; set; }
        public decimal Balance { get; set; }


    }
}
