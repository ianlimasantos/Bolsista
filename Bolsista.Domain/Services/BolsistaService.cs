using Bolsista.Domain.Interfaces.Repositories;
using Bolsista.Domain.Interfaces.Services;
using Bolsista.Domain.Models;
using Bolsista.Domain.Models.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Services
{
    public class BolsistaService : IBolsistaService
    {
        private readonly IBolsistaRepository _bolsistaRepository;

        public BolsistaService(IBolsistaRepository bolsistaRepository) 
        {
            _bolsistaRepository = bolsistaRepository;
        }
        public async Task<PessoaBolsista> CadastrarBolsista(PessoaBolsista pessoaBolsista)
        {
            await _bolsistaRepository.CadastrarBolsista(pessoaBolsista);
            return pessoaBolsista;
        }
        public async Task<PessoaBolsista> AtualizarBolsista(AtualizarBolsistaCommand command)
        {
            PessoaBolsista bolsista = await _bolsistaRepository.GetIdAsync(command.IdBolsista);
            if (bolsista == null) return null;

            bolsista.Atualizar(command.Nome, command.IdProjeto);
            await _bolsistaRepository.AtualizarBolsista(bolsista);
            await _bolsistaRepository.UnitOfWork.SaveChangesAsync();
            return bolsista;
        }

        public async Task<bool> DeletarBolsista(long id)
        {
            PessoaBolsista bolsista = await _bolsistaRepository.GetIdAsync(id);
            if (bolsista == null) return false;

            await _bolsistaRepository.DeletarBolsista(bolsista);
            return true;
        }
    }
}
