using ProjetoDanielEx.Core.Domain.Entities;
using ProjetoDanielEx.Core.WebApi.ViewModels.DTOs;
using ProjetoDanielEx.Core.WebApi.ViewModels.Request.Endereco;

namespace ProjetoDanielEx.Core.WebApi.Mapper
{
    public static class EnderecoEntityToViewModel
    {
        /// <summary>
        /// Request de inclusão do endereço por cliente
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static Endereco ToRequest(this RequestEndereco entity)
        {
            return new Endereco()
            {
                Codigo = entity.Codigo ?? 0,
                Logradouro = entity.Logradouro,
                Numero = entity.Numero,
                Complemento = !string.IsNullOrEmpty(entity.Complemento) ? entity.Complemento : string.Empty,
                Bairro = entity.Bairro,
                Cep = entity.Cep,
                Cidade = entity.Cidade,
                Estado = entity.Estado,
                CodigoCliente = entity?.CodigoCliente ?? 0
            };
        }

        public static EnderecoDTO ToResponse(this Endereco entity)
        {
            var retorno = new EnderecoDTO();

            if (entity != null)
            {

                retorno.Codigo = entity.Codigo;
                retorno.Logradouro = entity.Logradouro;
                retorno.Numero = entity.Numero;
                retorno.Complemento = !string.IsNullOrEmpty(entity.Complemento) ? entity.Complemento : string.Empty;
                retorno.Bairro = entity.Bairro;
                retorno.Cep = entity.Cep;
                retorno.Cidade = entity.Cidade;
                retorno.Estado = entity.Estado;
                retorno.CodigoCliente = entity?.CodigoCliente ?? 0;
            }

            return retorno;
        }
    }
}
