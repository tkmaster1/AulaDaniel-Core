using ProjetoDanielEx.Core.Domain.Entities;
using System.Threading.Tasks;

namespace ProjetoDanielEx.Core.Domain.Interfaces.Repositories
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    {
        Task<Cliente> NomeExiste(string nomeDoCliente);

        Task<Cliente> DocumentoExiste(string documento);

        Task<Cliente> ObterClienteEndereco(int codigoCliente);
    }
}
