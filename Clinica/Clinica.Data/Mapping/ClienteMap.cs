using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Data.Domain;
using System.Data.Entity.ModelConfiguration;


namespace Clinica.Data.Mapping
{
   public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            HasKey(x => x.Id);
            Property(x => x.NomeCompleto).HasMaxLength(255);
            Property(x => x.DataNascimento);
            Property(x => x.Telefone).HasMaxLength(12);
            Property(x => x.Email).HasMaxLength(150);
            Property(x => x.CPF).HasMaxLength(11);
            Property(x => x.RG).HasMaxLength(7);
            Property(x => x.Rua).HasMaxLength(100);
            Property(x => x.Cep).HasMaxLength(8);
            Property(x => x.Bairro).HasMaxLength(30);
            Property(x => x.Cidade).HasMaxLength(40);
            Property(x => x.UF).HasMaxLength(2);
            Property(x => x.Observacao);
        }
    }
}
