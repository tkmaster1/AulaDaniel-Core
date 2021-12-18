using ProjetoDanielEx.Core.Domain.Entities;
using ProjetoDanielEx.Core.Domain.Interfaces.Repositories;
using ProjetoDanielEx.Core.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoDanielEx.Core.Service.Application
{
    public class ClienteAppService : IClienteAppService
    {
        #region Properties

        private readonly IClienteRepository _clienteRepository;

        #endregion

        #region Constructor

        public ClienteAppService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        #endregion

        #region Methods

        public async Task<IEnumerable<Cliente>> ListarTodos()
        {
            return await _clienteRepository.ListarTodos();
        }

        public async Task<Cliente> ObterPorCodigo(int codigo)
        {
            return await _clienteRepository.ObterPorCodigo(codigo);
        }

        public async Task<int> Adicionar(Cliente entity)
        {
            _clienteRepository.Adicionar(entity);
            await _clienteRepository.Salvar();
            return entity.Codigo;
        }

        public async Task<bool> Atualizar(Cliente entity)
        {
            var model = await _clienteRepository.ObterPorCodigo(entity.Codigo);

            model.Nome = entity.Nome;
            model.Documento = entity.Documento;
            model.TipoPessoa = entity.TipoPessoa;

            _clienteRepository.Atualizar(model);

            return await _clienteRepository.Salvar() > 0;
        }

        public async Task<bool> Excluir(Cliente entity)
        {
            var model = await _clienteRepository.ObterPorCodigo(entity.Codigo);
            model.Status = false;
            _clienteRepository.Atualizar(model);

            return await _clienteRepository.Salvar() > 0;
        }

        public async Task<bool> Reativar(Cliente entity)
        {
            var model = await _clienteRepository.ObterPorCodigo(entity.Codigo);
            model.Status = true;
            _clienteRepository.Atualizar(model);

            return await _clienteRepository.Salvar() > 0;
        }

        public async Task<Cliente> NomeExiste(string nomeDoCliente)
        {
            return await _clienteRepository.NomeExiste(nomeDoCliente);
        }

        public async Task<Cliente> DocumentoExiste(string documento)
        {
            return await _clienteRepository.DocumentoExiste(documento);
        }

        public async Task<Cliente> ObterClienteEndereco(int codigoCliente)
        {
            return await _clienteRepository.ObterClienteEndereco(codigoCliente);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
