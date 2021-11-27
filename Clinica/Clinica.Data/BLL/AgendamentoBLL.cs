using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Data.Repository;
using Clinica.Data.Domain;
using Clinica.Model;

namespace Clinica.Data.BLL
{
    public class AgendamentoBLL : BaseBLL
    {
        public AgendamentoBLL()
        {
            agendamentoRepository = new AgendamentoRepository();
        }

        public async Task SaveOrUpdate(AgendamentoModel model)
        {
            try
            {
                if (ValidarModel(model))
                {
                    var domain = await ModelToDmonainAsync(model);

                    if (domain.Id == 0)
                        await agendamentoRepository.AddAsync(domain);
                    else
                        await agendamentoRepository.UpdateAsync(domain);
                }
            }
            catch (Exception e)
            {
                _noftificacao.Adicionar("");
            }
        }
        public async Task Delete(int id)
        {
            try
            {
                await agendamentoRepository.RemoveAsync(id);
            }
            catch (Exception e)
            {
                _noftificacao.Adicionar("");
            }
        }
        #region
        private async Task<Agendamento> ModelToDmonainAsync(AgendamentoModel model)
        {
            var domain = new Agendamento();

            if (model.Id > 0)
                domain = await agendamentoRepository.BuscarAsync(model.Id);

            return domain;
        }
        private bool ValidarModel(AgendamentoModel model)
        {
            return _noftificacao.TemMensagem;
        }
        #endregion
    }
}
