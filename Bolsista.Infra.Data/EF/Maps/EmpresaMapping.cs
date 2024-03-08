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
    public class EmpresaMapping : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.NomeFantasia).IsRequired();
            builder.Property(t => t.RazaoSocial).IsRequired();
            builder.Property(t => t.Cnpj).IsRequired();

            builder.HasMany(t => t.Projeto)
                .WithOne(t => t.Empresa);
               
        }
    }
}
