using Entities.Abstract;
using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Balance:IEntity
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public decimal Amount { get; set; }


    }
}
