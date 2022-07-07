using ProjetoDanielEx.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoDanielEx.Core.Domain.Interfaces.Repositories
{
    public interface IDocumentoRepository : IRepositoryBase<Documento>
    {
        Task<Documento> ObterDocumentoCliente(int codigo);

        Task<IEnumerable<Documento>> ListarTodosAtivos();

        Task<IEnumerable<Documento>> ListarDocumentosPorCliente(int codigoCliente);

        Task<ICollection<Documento>> BuscarDocumentosClientes(Documento docs);
    }
}
