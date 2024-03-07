using Bolsista.Domain.Models;
using Bolsista.Domain.Models.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Interfaces.Services
{
    public interface IProjetoService
    {
        Task<Projeto> CadastrarProjeto(Projeto projeto);
        Task<Projeto> AtualizarProjeto(AtualizarProjetoCommand command);
        Task<bool> DeletarProjeto(long id);
    }
}
