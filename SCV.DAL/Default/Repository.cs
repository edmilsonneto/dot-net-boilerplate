using System;
using System.Data;
using System.Data.Entity;
using System.Linq;

/// <summary>
/// Repositório de dados genério
/// </summary>
namespace SCV.DAL
{
    public abstract class Repository<TEntity> : IDisposable,
       IRepository<TEntity> where TEntity : class
    {
        Context ctx = new Context();

        public void Adicionar(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
        }

        public void Atualizar(TEntity obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
        }

        public void Excluir(Func<TEntity, bool> predicate)
        {
            ctx.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => ctx.Set<TEntity>().Remove(del));
        }

        public TEntity Procurar(params object[] key)
        {
            return ctx.Set<TEntity>().Find(key);
        }

        public IQueryable<TEntity> ObterTodos()
        {
            return ctx.Set<TEntity>();
        }

        public IQueryable<TEntity> Obter(Func<TEntity, bool> predicate)
        {
            return ObterTodos().Where(predicate).AsQueryable();
        }

        public void SalvarTodos()
        {
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}
