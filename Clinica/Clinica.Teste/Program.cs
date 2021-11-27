using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Data.Repository;

namespace Clinica.Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var repo = new ClienteRepository();
                var q = repo.UpdateAsync(new Data.Domain.Cliente {Id=4, NomeCompleto = "asdsadasd", Email = "asdsad", DataNascimento = DateTime.Today });
                q.Wait();
            }
            catch (Exception e)
            {
                var msg = e.Message;
            }
        }
    }
}
