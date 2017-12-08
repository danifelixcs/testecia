using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Linq;
using TesteSeusConhecimentos.Domain;
using TesteSeusConhecimentos.Entities;

namespace TesteSeusConhecimentos.Infra
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {

        public IList<TEntity> GetAll()
        {
            using (var session = FluentSessionFactory.abrirSession())
            {
                return (from e in session.Query<TEntity>() select e).ToList();
            }
        }
        public TEntity GetById(int id)
        {
            using (var session = FluentSessionFactory.abrirSession())
            {
                return session.Get<TEntity>(id);
            }
        }
        public void Delete(int id)
        {
            using (var session = FluentSessionFactory.abrirSession())
            {
                using (var transacao = session.BeginTransaction())
                {
                    try
                    {
                        var user = session.Get<TEntity>(id);
                        if (user != null)
                        {
                            session.Delete(user);
                            transacao.Commit();
                        }
                    }
                    catch (Exception e)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception($"Erro ao deletar {typeof(TEntity).Name}: {e.Message}");
                    }
                }
            }
        }
        public void Save(TEntity obj)
        {
            if (obj.IsNew())
                Add(obj);
            else
                Update(obj);
        }
        private void Add(TEntity obj)
        {
            using (var session = FluentSessionFactory.abrirSession())
            {
                using (var transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(obj);
                        transacao.Commit();
                    }
                    catch (Exception e)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception($"Erro ao inserir {typeof(TEntity).Name}: {e.Message}");
                    }
                }
            }
        }
        private void Update(TEntity obj)
        {
            using (var session = FluentSessionFactory.abrirSession())
            {
                using (var transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(obj);
                        transacao.Commit();
                    }
                    catch (Exception e)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception($"Erro ao atualizar {typeof(TEntity).Name}: {e.Message}");
                    }
                }
            }
        }
        public void Dispose()
        {
            
            
        }
    }
}
