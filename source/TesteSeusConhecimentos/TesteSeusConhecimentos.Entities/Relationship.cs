using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteSeusConhecimentos.Entities
{
    public class Relationship : BaseEntity
    {
        public virtual int IdEnterprise { get; set; }
        public virtual int IdUser { get; set; }

        public virtual Enterprise Enterprise { get; set; }
        public virtual User User { get; set; }

        public Relationship()
        {
            
        }
        public Relationship(int idRelationship, int idEnterprise, int idUser)
        {
            base.Id = idRelationship;
            IdEnterprise = idEnterprise;
            IdUser = idUser;
        }
    }
}
