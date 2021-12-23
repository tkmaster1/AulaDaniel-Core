using ProjetoDanielEx.Core.Domain.Entities;
using ProjetoDanielEx.Core.Domain.Interfaces.Repositories;

namespace ProjetoDanielEx.Core.Data.Repository
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        #region Constructor

        public EnderecoRepository(MeuContextoBDs context) : base(context) { }

        #endregion

        #region Methods

        #endregion
    }
}
