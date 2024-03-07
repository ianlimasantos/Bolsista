using Bolsista.Domain.Models;
using Bolsista.Domain.Models.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Interfaces.Services
{
    public interface IEmpresaService
    {
        Task<Empresa> CadastrarEmpresa(Empresa empresa);
        Task<Empresa> AtualizarEmpresa(AtualizarEmpresaCommand command);
        Task<bool> DeletarEmpresa(long id);
    }
}
