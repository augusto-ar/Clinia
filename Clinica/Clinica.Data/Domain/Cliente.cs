using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Data.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Observacao { get; set; }
        public virtual ICollection<Agendamento> Agendamentos { get; set; }
    }
}
