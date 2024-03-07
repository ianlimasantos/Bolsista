using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Models
{
    public class Empresa
    {
        public long Id { get; private set; }
        public string NomeFantasia { get; private set; }
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public virtual ICollection<Projeto> Projeto { get; private set; } 

        public Empresa(string nomeFantasia, string razaoSocial, string cnpj) 
        {
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
        }

        public void Atualizar(string nomeFantasia, string razaoSocial)
        {
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
        }

    }
}
