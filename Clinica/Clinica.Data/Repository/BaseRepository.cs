using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Data.Repository
{
    public abstract class BaseRepository<T> : IDisposable where T : class
    {
        private readonly ClinicaDbContext clinicaDb = new ClinicaDbContext();
        public void Dispose()
        {
        }
        public async Task AddAsync(T entidade)
        {
            clinicaDb.Set<T>().Add(entidade);
            await SaveAsync();
        }
        public async Task UpdateAsync(T entidade)
        {
            clinicaDb.Entry<T>(entidade).State = System.Data.Entity.EntityState.Modified;
            await SaveAsync();
        }
        public async Task RemoveAsync(object id)
        {
            var entidade = await BuscarAsync(id);
            clinicaDb.Set<T>().Remove(entidade);
            await SaveAsync();
        }
        public async Task<T> BuscarAsync(object id)
        {
            return await clinicaDb.Set<T>().FindAsync(id) ;
        }

        public IQueryable<T> ListarAsync()
        {
            return clinicaDb.Set<T>();
        }
        public async Task SaveAsync()
        {
            await clinicaDb.SaveChangesAsync();
        }
    }
}
