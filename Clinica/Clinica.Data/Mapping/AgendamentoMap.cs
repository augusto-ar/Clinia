using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Data.Domain;
using System.Data.Entity.ModelConfiguration;


namespace Clinica.Data.Mapping
{
    public class AgendamentoMap : EntityTypeConfiguration<Agendamento>
    {
        public AgendamentoMap()
        {
            ToTable("Agendamento");
            HasKey(x => x.Id);
            Property(x => x.NomeCompleto);
            Property(x => x.Telefone);
            Property(x => x.Celular);
            Property(x => x.Email);
            Property(x => x.Atendimento);
            Property(x => x.DataHora);
            //um pra muitos
            HasOptional(x => x.Clientes).WithMany(x => x.Agendamentos).HasForeignKey(x => x.IdCliente).WillCascadeOnDelete(true);
        }
    }
}
