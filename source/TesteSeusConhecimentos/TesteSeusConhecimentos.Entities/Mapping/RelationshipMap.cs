using FluentNHibernate.Mapping;

namespace TesteSeusConhecimentos.Entities.Mapping
{
    public class RelationshipMap : ClassMap<Relationship>
    {
        public RelationshipMap()
        {
            Id(c => c.Id).Column("IdRelationship");
            Map(c => c.IdEnterprise);
            Map(c => c.IdUser);
            HasOne(c => c.Enterprise).ForeignKey("IdEnterprise");
            HasOne(c => c.User).ForeignKey("IdUser");

            Schema("TesteSeusConhecimentos");
            Table("RelationshipData");
        }
    }
}
