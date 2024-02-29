using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Models
{
    public class PessoaBolsista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Projeto { get; set; }

        public PessoaBolsista(int id, string nome, string cPF, int projeto)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Projeto = projeto;
        }

        public void Atualizar(string nome, int projeto)
        {
            Nome = nome;
            Projeto = projeto;
        }
    }
}
