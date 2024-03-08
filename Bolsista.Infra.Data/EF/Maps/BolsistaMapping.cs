using Bolsista.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Infra.Data.EF.Maps
{
    public class BolsistaMapping : IEntityTypeConfiguration<PessoaBolsista>
    {
        public void Configure(EntityTypeBuilder<PessoaBolsista> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.CPF).IsRequired();
            builder.Property(x => x.ProjetoId).IsRequired();

            builder.HasOne(t => t.Projeto)
                .WithMany(t => t.PessoasBolsistas)
                .HasForeignKey(t => t.ProjetoId);

        }
    }
}
