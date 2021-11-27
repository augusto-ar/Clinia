using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Data.Repository;
using Clinica.Model;
using Clinica.Data.Domain;

namespace Clinica.Data.BLL
{
    public class ClienteBLL : BaseBLL
    {
        public ClienteBLL()
        {
            clienteRepository = new ClienteRepository();
        }

        public async Task SaveOrUpdate(ClienteModel model)
        {
            try
            {
                if (ValidarModel(model))
                {
                    var domain = await ModelToDomainAsync(model);
                    if (model.Id == 0)
                        await clienteRepository.AddAsync(domain);
                    else
                        await clienteRepository.UpdateAsync(domain);
                }
            }
            catch (Exception e)
            {
                _noftificacao.Adicionar("");
            }
        }
        public async Task DeleteAsync(int id)
        {
            try
            {
                await clienteRepository.RemoveAsync(id);
            }
            catch (Exception e)
            {
                _noftificacao.Adicionar("");
            }
        }
        public ClienteModel GetCliente(int id)
        {
            return clienteRepository.ListarAsync()
               .Where(x => x.Id == id)
              .Select(x => new ClienteModel
              {

              }).FirstOrDefault();
        }
        public List<ClienteModel> Lista(int take, int skip)
        {
            return usuarioRepository.ListarAsync()
                .Skip(skip).Take(take)
                .Select(x => new ClienteModel
                {

                }).ToList();
        }
        #region
        private bool ValidarModel(ClienteModel model)
        {
            return _noftificacao.TemMensagem;
        }
        private async Task<Cliente> ModelToDomainAsync(ClienteModel model)
        {
            Cliente cliente;
            if (model.Id != 0)
                cliente = await clienteRepository.BuscarAsync(model.Id);
            else
                cliente = new Cliente();

            return cliente;
        }
        #endregion
    }
}
