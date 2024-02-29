using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Models
{
    public class Projeto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public int Empresa {  get; private set; }

        public Projeto(string nome, string descricao, int empresa)
        {
            Nome = nome;
            Descricao = descricao;
            Empresa = empresa;
        }

        public void Atualizar(string nome, string descricao, int empresa)
        {
            Nome = nome;
            Descricao = descricao;
            Empresa = empresa;
        }
    }
}
