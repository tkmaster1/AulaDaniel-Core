using Microsoft.EntityFrameworkCore;
using ProjetoDanielEx.Core.Domain.Entities;
using ProjetoDanielEx.Core.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDanielEx.Core.Data.Repository
{
    public class DocumentoRepository : RepositoryBase<Documento>, IDocumentoRepository
    {
        #region Constructor

        public DocumentoRepository(MeuContextoBDs contextoBDs) : base(contextoBDs) { }

        #endregion

        #region Methods

        public async Task<ICollection<Documento>> BuscarDocumentosClientes(Documento docs)
        {
            var query = Db.Documentos.AsNoTracking()
                                     .Include(x => x.Cliente)
                                       .ThenInclude(x => x.Endereco)
                                    .AsQueryable();

            if (docs.CodigoCliente != 0)
            {
                query = query.Where(x => x.CodigoCliente == docs.CodigoCliente);
            }

            if (!string.IsNullOrEmpty(docs.Nome))
            {
                query = query.Where(x => x.Nome.Trim().ToUpper().Contains(docs.Nome.Trim().ToUpper()));
            }

            var retorno = await query.OrderBy(x => x.Nome).ToListAsync();
            return retorno;
        }

        public async Task<IEnumerable<Documento>> ListarDocumentosPorCliente(int codigoCliente)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Documento>> ListarTodosAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<Documento> ObterDocumentoCliente(int codigo)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
