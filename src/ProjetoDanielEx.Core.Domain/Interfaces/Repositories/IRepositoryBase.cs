using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjetoDanielEx.Core.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);

        void Adicionar(IEnumerable<TEntity> entities);

        void Atualizar(TEntity entity);

        void Atualizar(IEnumerable<TEntity> entities);

        Task<TEntity> ObterPorCodigo(int codigo);

        Task<IEnumerable<TEntity>> ObterPorCodigos(IEnumerable<int> codigos);

        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> ObterPorNome(string nome);

        Task<bool> Existe(int codigo);

        Task<IEnumerable<TEntity>> ListarTodos();

        void Remover(int codigo);

        void Remover(TEntity entity);

        Task<int> Salvar();

        IQueryable<TEntity> Get();
    }
}
