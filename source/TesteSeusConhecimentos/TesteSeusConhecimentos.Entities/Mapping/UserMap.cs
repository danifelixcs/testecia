using FluentNHibernate.Mapping;

namespace TesteSeusConhecimentos.Entities.Mapping
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(c => c.Id).Column("IdUser");
            Map(c => c.Name);
            Map(c => c.LastName);
            Map(c => c.Email);

            Schema("TesteSeusConhecimentos");
            Table("UserData");
        }

    }
}
