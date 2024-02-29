using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Models.Command
{
    public class AtualizarBolsistaCommand
    {
        public int IdBolsista { get; set; }
        public string Nome { get; set; }
        public int IdProjeto { get; set; }
    }
}
