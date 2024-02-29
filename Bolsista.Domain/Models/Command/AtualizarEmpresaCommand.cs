using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Models.Command
{
    public class AtualizarEmpresaCommand
    {
        public int Id { get; set; }
        public string Razao_Social { get; set; }
        public string Nome_Fantasia { get; set; }
    }
}
