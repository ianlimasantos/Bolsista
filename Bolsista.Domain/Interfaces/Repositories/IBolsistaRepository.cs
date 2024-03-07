using Bolsista.Domain.Models;

namespace Bolsista.Domain.Interfaces.Repositories
{
    public interface IBolsistaRepository : IBaseRepository<PessoaBolsista>
    {
        Task CadastrarBolsista(PessoaBolsista bolsista);
        Task AtualizarBolsista(PessoaBolsista bolsista);
        Task DeletarBolsista(PessoaBolsista bolsista);
    }
}
