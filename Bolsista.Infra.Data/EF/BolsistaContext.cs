using Bolsista.Domain.Interfaces;
using Bolsista.Domain.Models;
using Bolsista.Infra.Data.EF.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Infra.Data.EF
{
    public class BolsistaContext : DbContext, IUnitOfWork
    {
        public BolsistaContext(DbContextOptions options): base(options) 
        { 
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BolsistaMapping());
            modelBuilder.ApplyConfiguration(new EmpresaMapping());
            modelBuilder.ApplyConfiguration(new ProjetoMapping());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<PessoaBolsista> Bolsista;
        public DbSet<Empresa> Empresa;
        public DbSet<Projeto> Projeto;
        
    }
}
