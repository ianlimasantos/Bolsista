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
    public class ProjetoMapping : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome)
                .HasColumnName("nome")
                .IsRequired();

            builder.Property(t => t.Descricao)
                .HasColumnName("")
                .IsRequired();
        }
    }
}
