﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Domain.Models.Command
{
    public class AtualizarProjetoCommand
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao {get; set;}
    }
}
