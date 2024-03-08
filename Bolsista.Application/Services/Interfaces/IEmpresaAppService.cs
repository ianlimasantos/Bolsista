using Bolsista.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Application.Services.Interfaces
{
    public interface IEmpresaAppService
    {
        Task<EmpresaViewModel> CadastrarEmpresa(EmpresaViewModel empresa);
    }
}
