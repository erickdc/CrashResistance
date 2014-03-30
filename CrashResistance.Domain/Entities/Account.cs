using System.Collections.Generic;

namespace MiniTrello.Domain.Entities
{
    public class Account : IEntity
    {
        
        public virtual string Token { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual string UserName { get; set; }

        public virtual long Score { get; set; }

        public virtual long NewScore { get; set; }
        

        public virtual long Id { get; set; }
        public virtual bool IsArchived { get; set; }

        
    }
}