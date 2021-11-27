using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Model
{
    public enum AtendimentoModel
    {

    }
    public class AgendamentoModel
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Observacao { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public DateTime DataHora { get; set; }
        public int? IdCliente { get; set; }
        public AtendimentoModel Atendimento { get; set; }
    }
}
