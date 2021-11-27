using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Data.Domain;
using System.Data.Entity.ModelConfiguration;


namespace Clinica.Data.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");
            HasKey(x => x.Id);
            Property(x => x.Email ).HasMaxLength(100);
            Property(x => x.Login ).HasMaxLength(20);
            Property(x => x.Senha ).HasMaxLength(16);
            Property(x => x.Nome ).HasMaxLength(255);
        }
    }
}
