using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.Avaliacao.Dominio.Entidades;

namespace Uniplac.Avaliacao.Infra.Dados.Contexto
{
    public class LojaContexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Aluga> Alugas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        public LojaContexto() : base("EdmundoTrabalhoFinalDB")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .ToTable("TBCliente");

            modelBuilder.Entity<Cliente>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Cliente>()
                .Property(p => p.PrimeiroNome)
                  .HasColumnType("varchar")
                  .HasMaxLength(150)
                  .IsRequired();

            modelBuilder.Entity<Cliente>()
                .Property(p => p.Sobrenome)
                  .HasColumnType("varchar")
                  .HasMaxLength(150)
                  .IsRequired();

            modelBuilder.Entity<Cliente>()
                .Property(p => p.Cpf)
                  .HasColumnType("varchar")
                  .HasMaxLength(150)
                  .IsRequired();

            modelBuilder.Entity<Cliente>()
                .Property(p => p.Telefone)
                  .HasColumnType("varchar")
                  .HasMaxLength(150)
                  .IsRequired();

             modelBuilder.Entity<Cliente>()
                  .Property(c => c.DataNascimento)
                    .HasColumnType("datetime")
                    .IsRequired();



            modelBuilder.Entity<Veiculo>()
               .ToTable("TBVeiculo");

            modelBuilder.Entity<Veiculo>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Veiculo>()
                  .Property(c => c.Marca)
                  .HasColumnType("varchar")
                  .HasMaxLength(150)
                  .IsRequired();

            modelBuilder.Entity<Veiculo>()
                  .Property(c => c.Modelo)
                  .HasColumnType("varchar")
                  .HasMaxLength(150)
                  .IsRequired();

            modelBuilder.Entity<Veiculo>()
                  .Property(c => c.Placa)
                  .HasColumnType("varchar")
                  .HasMaxLength(150)
                  .IsRequired();

            modelBuilder.Entity<Veiculo>()
                  .Property(c => c.Chassi)
                  .HasColumnType("varchar")
                  .HasMaxLength(150)
                  .IsRequired();

            modelBuilder.Entity<Veiculo>()
                  .Property(c => c.Renavam)
                  .HasColumnType("varchar")
                  .HasMaxLength(150)
                  .IsRequired();

            modelBuilder.Entity<Veiculo>()
                  .Property(c => c.Ano)
                  .HasColumnType("int")
                  .IsRequired();


            modelBuilder.Entity<Aluga>()
               .ToTable("TBAluga");

            modelBuilder.Entity<Aluga>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Aluga>()
                  .Property(p => p.Valor)
                  .IsRequired();

            modelBuilder.Entity<Aluga>()
                  .Property(p => p.QuantDia)
                  .IsRequired();

            modelBuilder.Entity<Aluga>()
                 .HasRequired(a => a.IdCliente)
                 .WithMany()
                 .WillCascadeOnDelete(true);

            modelBuilder.Entity<Aluga>()
                   .HasRequired(a => a.IdVeiculo)
                   .WithMany()
                   .WillCascadeOnDelete(true);

        }
    }
}