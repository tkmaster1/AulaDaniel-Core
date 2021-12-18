using ProjetoDanielEx.Common.Utilities;
using ProjetoDanielEx.Core.Domain.Entities;
using ProjetoDanielEx.Core.WebApi.ViewModels.DTOs;
using ProjetoDanielEx.Core.WebApi.ViewModels.Request.Cliente;

namespace ProjetoDanielEx.Core.WebApi.Mapper
{
    public static class ClienteEntityToViewModel
    {
        public static ClienteDTO ToResponse(this Cliente entity)
        {
            return new ClienteDTO()
            {
                Codigo = entity.Codigo,
                Nome = entity.Nome,
                Status = entity.Status,
                Documento = entity.Documento,
                TipoPessoa = entity.TipoPessoa.Trim().ToUpper()
            };
        }

        public static ClienteDTO ToResponseClienteEndereco(this Cliente entity)
        {
            return new ClienteDTO()
            {
                Codigo = entity.Codigo,
                Nome = entity.Nome,
                Status = entity.Status,
                Documento = entity.Documento,
                TipoPessoa = entity.TipoPessoa.Trim().ToUpper(),
                Endereco = entity?.Endereco.ToResponse() ?? new EnderecoDTO()
            };
        }

        public static Cliente ToRequest(this RequestAdicionarCliente request)
        {
            var retorno = new Cliente();

            if (request != null)
            {
                retorno.Nome = request.Nome;
                retorno.Documento = Util.RemoveNaoNumericos(request.Documento);
                retorno.TipoPessoa = request.TipoPessoa.Trim().ToUpper();
               
                retorno.Endereco = request?.Endereco.ToRequest() ?? new Endereco();
            }

            return retorno;

            //return new Cliente()
            //{
            //    Nome = request.Nome,
            //    Documento = Util.RemoveNaoNumericos(request.Documento),
            //    TipoPessoa = request.TipoPessoa.Trim().ToUpper()
            //};
        }

        public static Cliente ToRequest(this RequestAtualizarCliente request)
        {
            return new Cliente()
            {
                Codigo = request.Codigo,
                Nome = request.Nome,
                Documento = Util.RemoveNaoNumericos(request.Documento),
                TipoPessoa = request.TipoPessoa.Trim().ToUpper()
            };
        }

        public static Cliente ToRequest(this RequestReativarExcluirCliente request)
        {
            return new Cliente()
            {
                Codigo = request.Codigo
            };
        }
    }
}
