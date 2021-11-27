using System.Data.Entity;
using System.Reflection;



namespace Clinica.Data
{
   public class ClinicaDbContext : DbContext
    {
        public ClinicaDbContext() : base("name=Clinica")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(GetType()));
            base.OnModelCreating(modelBuilder);
        }
    }
}
