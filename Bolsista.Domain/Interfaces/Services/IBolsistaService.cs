using Bolsista.Domain.Models;
using Bolsista.Domain.Models.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Interfaces.Services
{
    public interface IBolsistaService
    {
        Task<PessoaBolsista> CadastrarBolsista(PessoaBolsista pessoaBolsista);
        Task<PessoaBolsista> AtualizarBolsista(AtualizarBolsistaCommand command);
        Task<bool> DeletarBolsista(long id);
    }
}
