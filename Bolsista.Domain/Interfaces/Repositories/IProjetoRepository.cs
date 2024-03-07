using Bolsista.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Interfaces.Repositories
{
    public interface IProjetoRepository : IBaseRepository<Projeto>
    {
        Task<Projeto> CadastrarProjeto(Projeto projeto);
        Task AtualizarProjeto(Projeto projeto);
        Task DeletarProjeto(Projeto projeto);
    }
}
