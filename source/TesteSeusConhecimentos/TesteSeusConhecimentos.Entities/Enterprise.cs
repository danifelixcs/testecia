namespace TesteSeusConhecimentos.Entities
{
    public class Enterprise : BaseEntity
    {
        public virtual string StreetAddress { get; set; }
        public virtual string City { get; set; }
        public virtual string ZipCode { get; set; }
        public virtual string CorporateActivity { get; set; }

        public Enterprise()
        {

        }
        public Enterprise(int idEnterprise, string streetAddress, string city, string zipCode, string corporateActivity)
        {

            this.Id = idEnterprise;
            StreetAddress = streetAddress;
            City = city;
            ZipCode = zipCode;
            CorporateActivity = corporateActivity;
        }
    }
}



