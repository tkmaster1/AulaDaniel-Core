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
                DescricaoStatus = entity.Status ? "Ativo" : "Inativo",
                Documento = entity.Documento,
                TipoPessoa = entity.TipoPessoa.Trim().ToUpper()
            };
        }

        public static Cliente ToRequest(this RequestCliente request)
        {
            return new Cliente()
            {
                Nome = request.Nome,
                Documento = request.Documento,
                TipoPessoa = request.TipoPessoa.Trim().ToUpper()
            };
        }

        public static Cliente ToRequest(this RequestAtualizarCliente request)
        {
            return new Cliente()
            {
                Codigo = request.Codigo,
                Nome = request.Nome,
                Documento = request.Documento,
                TipoPessoa = request.TipoPessoa.Trim().ToUpper()
            };
        }

        public static Cliente ToRequest(this RequestExcluirCliente request)
        {
            return new Cliente()
            {
                Codigo = request.Codigo
            };
        }
    }
}
