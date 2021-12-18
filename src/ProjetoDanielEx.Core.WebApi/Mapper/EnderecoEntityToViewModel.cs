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
        public static Endereco ToRequest(this RequestAdicionarEndereco entity)
        {
            return new Endereco()
            {
                Logradouro = entity.Logradouro,
                Numero = entity.Numero,
                Complemento = entity.Complemento,
                Bairro = entity.Bairro,
                Cep = entity.Cep,
                Cidade = entity.Cidade,
                Estado = entity.Estado,
                CodigoCliente = entity?.CodigoCliente
            };
        }

        ///// <summary>
        ///// Request de atualização do endereço por cliente
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        //public static Endereco ToRequest(this RequestAtualizarEndereco entity)
        //{
        //    return new Endereco()
        //    {
        //        Codigo = entity.Codigo,
        //        Logradouro = entity.Logradouro,
        //        Numero = entity.Numero,
        //        Complemento = entity.Complemento,
        //        Bairro = entity.Bairro,
        //        Cep = entity.Cep,
        //        Cidade = entity.Cidade,
        //        Estado = entity.Estado,
        //        CodigoCliente = entity?.CodigoCliente,
        //        //DataAlteracao = System.DateTime.Now,
        //        //Status = true
        //    };
        //}

        public static EnderecoDTO ToResponse(this Endereco entity)
        {
            return new EnderecoDTO()
            {
                Codigo = entity.Codigo,
                Logradouro = entity.Logradouro,
                Numero = entity.Numero,
                Complemento = entity.Complemento,
                Bairro = entity.Bairro,
                Cep = entity.Cep,
                Cidade = entity.Cidade,
                Estado = entity.Estado,
                CodigoCliente = entity?.CodigoCliente
            };
        }
    }
}
