using Bolsista.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Interfaces.Repositories
{
    public interface IEmpresaRepository : IBaseRepository<Empresa>
    {
        Task<Empresa> CadastrarEmpresa(Empresa empresa);
        Task AtualizarEmpresa(Empresa empresa);
        Task DeletarEmpresa(Empresa empresa);
    }
}
