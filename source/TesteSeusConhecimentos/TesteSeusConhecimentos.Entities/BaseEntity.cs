
namespace TesteSeusConhecimentos.Entities
{
    public class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual bool IsNew()
        {
            return this.Id == 0;
        }
    }
}
