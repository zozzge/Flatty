using Entities.Abstract;
using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class GroupUser:IEntity
    {
        public int GroupId { get; set; }
        public Group Group { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }


    }
}
