using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Data.Notificacao
{
    public class NotificacaoModel
    {
        public NotificacaoModel()
        {

        }

        private string Menssagem;

        public void Adicionar(string texto)
        {
            Menssagem = texto;
        }
        public bool TemMensagem
        {
            get
            {
                return string.IsNullOrEmpty(Menssagem);
            }
        }
        

        public string MensagemFormatada()
        {
            return Menssagem;
        }
    }
}
