using Bolsista.Domain.Interfaces;
using Bolsista.Domain.Interfaces.Repositories;
using Bolsista.Domain.Models;
using Bolsista.Infra.Data.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Infra.Data.Repositories
{
    public class BolsistaRepository : BaseRepository<PessoaBolsista>, IBolsistaRepository
    {
        private readonly BolsistaContext _context;

        public BolsistaRepository(BolsistaContext context) : base(context)
        {
            _context = context;
        }

        public async Task CadastrarBolsista(PessoaBolsista bolsista)
        {
            await _context.Bolsista.AddAsync(bolsista);
        }

        public async Task AtualizarBolsista(PessoaBolsista bolsista)
        {
            await Task.FromResult(_context.Bolsista.Update(bolsista));
        }

        public async Task DeletarBolsista(PessoaBolsista bolsista)
        {
            await Task.FromResult(_context.Bolsista.Remove(bolsista));
        }

    }
}
