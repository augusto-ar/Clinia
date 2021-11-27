using Clinica.Data.Notificacao;
using Clinica.Data.Repository;

namespace Clinica.Data.BLL
{
   public abstract class BaseBLL
    {
        public UsuarioRepository usuarioRepository;
        public AgendamentoRepository agendamentoRepository;
        public ClienteRepository clienteRepository;
        public NotificacaoModel _noftificacao = new NotificacaoModel();
    }
}
