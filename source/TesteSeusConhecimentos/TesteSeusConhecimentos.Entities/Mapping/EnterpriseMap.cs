using FluentNHibernate.Mapping;
namespace TesteSeusConhecimentos.Entities.Mapping
{
    public class EnterpriseMap : ClassMap<Enterprise>
    {
        public EnterpriseMap()
        {
            Id(c => c.Id).Column("IdEnterprise");
            Map(c => c.StreetAddress);
            Map(c => c.City);
            Map(c => c.ZipCode);
            Map(c => c.CorporateActivity);

            Schema("TesteSeusConhecimentos");
            Table("EnterpriseData");
        }

    }
}