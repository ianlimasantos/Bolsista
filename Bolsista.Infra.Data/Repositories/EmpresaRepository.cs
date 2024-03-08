using Bolsista.Domain.Interfaces.Repositories;
using Bolsista.Domain.Models;
using Bolsista.Infra.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Infra.Data.Repositories
{
    public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
    {
        private readonly BolsistaContext _context;
        public EmpresaRepository(BolsistaContext context) : base(context)
        {
        }
        public async Task<Empresa> CadastrarEmpresa(Empresa empresa)
        {
            await Task.FromResult(_context.Add(empresa));
            return empresa;
        }

        public Task AtualizarEmpresa(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public Task DeletarEmpresa(Empresa empresa)
        {
            throw new NotImplementedException();
        }
    }
}
