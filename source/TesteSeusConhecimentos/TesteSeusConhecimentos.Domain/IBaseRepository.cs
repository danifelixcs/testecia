using System;
using System.Collections.Generic;
using TesteSeusConhecimentos.Entities;

namespace TesteSeusConhecimentos.Domain
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        IList<TEntity> GetAll();
        TEntity GetById(int id);
        void Delete(int id);
        void Save(TEntity user);
    }
}
