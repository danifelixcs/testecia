using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteSeusConhecimentos.Entities
{
    public class User : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }

        public User()
        {

        }
        public User(int idUser, string name, string lastName, string email)
        {
            this.Id = idUser;
            this.Name = name;
            this.LastName = lastName;
            this.Email = email;
        }
    }
}
