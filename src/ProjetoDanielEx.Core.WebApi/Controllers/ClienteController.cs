using Microsoft.AspNetCore.Mvc;
using ProjetoDanielEx.Core.Domain.Interfaces.Notifications;
using ProjetoDanielEx.Core.Domain.Interfaces.Services;
using ProjetoDanielEx.Core.Domain.Notifications;
using ProjetoDanielEx.Core.WebApi.Mapper;
using ProjetoDanielEx.Core.WebApi.ViewModels.Request.Cliente;
using ProjetoDanielEx.Core.WebApi.ViewModels.Responses;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDanielEx.Core.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : APIController
    {
        #region Properties

        private readonly IClienteAppService _clienteAppServ;

        #endregion

        #region Constructor

        public ClienteController(INotificationHandler<DomainNotification> notifications,
            IClienteAppService clienteAppServ) : base(notifications)
        {
            _clienteAppServ = clienteAppServ;
        }

        #endregion

        #region Methods

        [HttpGet("ListarTodos")]
        [Consumes("application/Json")]
        [Produces("application/Json")]
        [ProducesResponseType(typeof(ResponseEntidadeBase), 200)]
        [ProducesResponseType(typeof(ResponseFalha), 400)]
        [ProducesResponseType(typeof(ResponseFalha), 403)]
        [ProducesResponseType(typeof(ResponseFalha), 409)]
        [ProducesResponseType(typeof(ResponseFalha), 500)]
        [ProducesResponseType(typeof(ResponseFalha), 502)]
        public async Task<IActionResult> ListarTodos()
        {
            var retorno = await _clienteAppServ.ListarTodos();
            return Response(retorno.Select(x => x.ToResponse()));
        }

        [HttpGet("ObterPorCodigo/{codigo}")]
        [Consumes("application/Json")]
        [Produces("application/Json")]
        [ProducesResponseType(typeof(ResponseEntidadeBase), 200)]
        [ProducesResponseType(typeof(ResponseFalha), 400)]
        [ProducesResponseType(typeof(ResponseFalha), 403)]
        [ProducesResponseType(typeof(ResponseFalha), 409)]
        [ProducesResponseType(typeof(ResponseFalha), 500)]
        [ProducesResponseType(typeof(ResponseFalha), 502)]
        public async Task<IActionResult> ObterPorCodigo(int codigo)
        {
            var retorno = await _clienteAppServ.ObterPorCodigo(codigo);
            return Response(retorno?.ToResponse());
        }

        [HttpPost("Adicionar")]
        [Consumes("application/Json")]
        [Produces("application/Json")]
        [ProducesResponseType(typeof(ResponseEntidadeBase), 200)]
        [ProducesResponseType(typeof(ResponseFalha), 400)]
        [ProducesResponseType(typeof(ResponseFalha), 403)]
        [ProducesResponseType(typeof(ResponseFalha), 409)]
        [ProducesResponseType(typeof(ResponseFalha), 500)]
        [ProducesResponseType(typeof(ResponseFalha), 502)]
        public async Task<IActionResult> Adicionar([FromBody] RequestAdicionarCliente request)
        {
            return Response(await _clienteAppServ.Adicionar(request.ToRequest()));
        }

        [HttpPut("Atualizar")]
        [Consumes("application/Json")]
        [Produces("application/Json")]
        [ProducesResponseType(typeof(ResponseEntidadeBase), 200)]
        [ProducesResponseType(typeof(ResponseFalha), 400)]
        [ProducesResponseType(typeof(ResponseFalha), 403)]
        [ProducesResponseType(typeof(ResponseFalha), 409)]
        [ProducesResponseType(typeof(ResponseFalha), 500)]
        [ProducesResponseType(typeof(ResponseFalha), 502)]
        public async Task<IActionResult> Atualizar([FromBody] RequestAtualizarCliente request)
        {
            return Response(await _clienteAppServ.Atualizar(request.ToRequest()));
        }

        [HttpPut("Excluir")]
        [Consumes("application/Json")]
        [Produces("application/Json")]
        [ProducesResponseType(typeof(ResponseEntidadeBase), 200)]
        [ProducesResponseType(typeof(ResponseFalha), 400)]
        [ProducesResponseType(typeof(ResponseFalha), 403)]
        [ProducesResponseType(typeof(ResponseFalha), 409)]
        [ProducesResponseType(typeof(ResponseFalha), 500)]
        [ProducesResponseType(typeof(ResponseFalha), 502)]
        public async Task<IActionResult> Excluir([FromBody] RequestReativarExcluirCliente request)
        {
            return Response(await _clienteAppServ.Excluir(request.ToRequest()));
        }

        [HttpPut("Reativar")]
        [Consumes("application/Json")]
        [Produces("application/Json")]
        [ProducesResponseType(typeof(ResponseEntidadeBase), 200)]
        [ProducesResponseType(typeof(ResponseFalha), 400)]
        [ProducesResponseType(typeof(ResponseFalha), 403)]
        [ProducesResponseType(typeof(ResponseFalha), 409)]
        [ProducesResponseType(typeof(ResponseFalha), 500)]
        [ProducesResponseType(typeof(ResponseFalha), 502)]
        public async Task<IActionResult> Reativar([FromBody] RequestReativarExcluirCliente request)
        {
            return Response(await _clienteAppServ.Reativar(request.ToRequest()));
        }

        #endregion
    }
}
