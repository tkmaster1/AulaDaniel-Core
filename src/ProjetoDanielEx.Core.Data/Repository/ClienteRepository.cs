using ProjetoDanielEx.Core.Domain.Entities;
using ProjetoDanielEx.Core.Domain.Interfaces.Repositories;

namespace ProjetoDanielEx.Core.Data.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        #region Constructor

        public ClienteRepository(MeuContextoBDs context) : base(context) { }

        #endregion

        #region Methods  
        #endregion
    }
}
