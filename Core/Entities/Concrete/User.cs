using Core.Entities.Concrete;
using Entities.Abstract;
using System.Text.RegularExpressions;


    namespace Core.Entities.Concrete
    {
        public class User : IEntity
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public ICollection<GroupUser> GroupUsers { get; set; }
            public string EMail { get; set; }
            public byte[] PasswordHash { get; set; }
            public byte[] PasswordSalt { get; set; }
            public bool Status { get; set; }
        }
    
    
        
    
     }
