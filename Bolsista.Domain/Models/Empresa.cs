using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

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
