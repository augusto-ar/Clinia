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
    public class UsuarioBLL : BaseBLL
    {
        public UsuarioBLL()
        {
            usuarioRepository = new UsuarioRepository();
        }

        public async Task SaveOrUpdate(UsuarioModel model)
        {
            try
            {
                if (ValidarModel(model))
                {
                    var domain = await ModelToDomainAsync(model);

                    if (domain.Id == 0)
                        await usuarioRepository.AddAsync(domain);
                    else
                        await usuarioRepository.UpdateAsync(domain);
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
                await usuarioRepository.RemoveAsync(id);
            }
            catch (Exception e)
            {
                _noftificacao.Adicionar("");
            }
        }

        public UsuarioModel GetUsuario(int id)
        {
            return usuarioRepository.ListarAsync()
                .Where(x=> x.Id == id)
               .Select(x => new UsuarioModel
               {

               }).FirstOrDefault();
        }

        public List<UsuarioModel> Lista(int take, int skip)
        {
            return usuarioRepository.ListarAsync()
                .Skip(skip).Take(take)
                .Select(x => new UsuarioModel { 
                
                }).ToList();
        }

        public UsuarioModel Login(LoginModel model)
        {
            return   usuarioRepository.ListarAsync()
                .Where(x => x.Login == model.Login && x.Senha == model.Password)
               .Select(x => new UsuarioModel
               {

               }).FirstOrDefault();
        }

        #region
        private bool ValidarModel(UsuarioModel model)
        {
            return _noftificacao.TemMensagem;
        }
        private async Task<Usuario> ModelToDomainAsync(UsuarioModel model)
        {
            Usuario usuario;
            if (model.Id != 0)
                usuario = await usuarioRepository.BuscarAsync(model.Id);
            else
                usuario = new Usuario();

            return usuario;
        }
        #endregion
    }
}
