using ProjetoDanielEx.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoDanielEx.Core.Domain.Interfaces.Services
{
    public interface IClienteAppService : IDisposable
    {
        Task<IEnumerable<Cliente>> ListarTodos();

        Task<Cliente> ObterPorCodigo(int codigo);

        Task<int> Adicionar(Cliente entity);

        Task<bool> Atualizar(Cliente entity);

        Task<bool> Excluir(Cliente entity);

        Task<bool> Reativar(Cliente entity);
    }
}
