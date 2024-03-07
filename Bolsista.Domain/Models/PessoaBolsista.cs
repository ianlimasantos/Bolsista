using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Models
{
    public class PessoaBolsista
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int ProjetoId { get; set; }
        public virtual Projeto Projeto { get; private set; }

        public PessoaBolsista(int id, string nome, string cPF, int projeto)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            ProjetoId = projeto;
        }

        public void Atualizar(string nome, int projeto)
        {
            Nome = nome;
            ProjetoId = projeto;
        }
    }
}
