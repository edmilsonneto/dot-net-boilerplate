using System;
using System.Linq;

/// <summary>
/// Interface repositório genérico para persistência de dados
/// </summary>
namespace SCV.DAL
{
    interface IRepository<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);
        void Atualizar(TEntity obj);
        TEntity Procurar(params object[] key);
        IQueryable<TEntity> ObterTodos();
        IQueryable<TEntity> Obter(Func<TEntity, bool> predicate);
        void SalvarTodos();
        void Excluir(Func<TEntity, bool> predicate);
    }
}
