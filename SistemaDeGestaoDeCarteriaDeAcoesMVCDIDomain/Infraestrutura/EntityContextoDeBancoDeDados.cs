using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Infraestrutura
{
    public class GestaoDeCarteiraDBContext : DbContext
    {
        public DbSet<Acao> Acao { get; set; }
        public DbSet<Carteira> Carteira { get; set; }
        public DbSet<Operacao> Operacao { get; set; }
        public DbSet<Empresa> Empresa { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Database.SetInitializer<GestaoDeCarteiraDBContext>(null);

            modelBuilder.Entity<Acao>().Property(acao => acao.Codigo).HasColumnName("CODIGO").IsRequired();
            modelBuilder.Entity<Acao>().HasKey(acao => acao.Codigo);
            modelBuilder.Entity<Acao>().HasRequired(acao => acao.Empresa).WithMany().Map(m => m.MapKey("CNPJ"));
            modelBuilder.Entity<Acao>();
            modelBuilder.Entity<Acao>().ToTable("Acao");

            modelBuilder.Entity<Empresa>().ToTable("Empresa");
            modelBuilder.Entity<Empresa>().Property(empresa => empresa.CNPJEmpresa).HasColumnName("CNPJ").IsRequired();
            modelBuilder.Entity<Empresa>().HasKey(empresa => empresa.CNPJEmpresa);
            modelBuilder.Entity<Empresa>().Property(empresa => empresa.Razaosocial).HasColumnName("RAZAOSOCIAL").IsRequired();

            modelBuilder.Entity<Carteira>().Property(carteira => carteira.ID).HasColumnName("ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Carteira>().HasKey(carteira => carteira.ID);
            modelBuilder.Entity<Carteira>()
                .HasMany(carteira => carteira.Operacoes)
                .WithRequired()
                .Map(m => m.MapKey("ID_CARTEIRA"));
            modelBuilder.Entity<Carteira>().ToTable("Carteira");

            modelBuilder.Entity<Operacao>().HasKey(operacao => operacao.ID);
            modelBuilder.Entity<Operacao>()
                .Property(operacao => operacao.ID)
                .IsRequired()
                .HasColumnName("ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Operacao>()
                .HasRequired(operacao => operacao.Acao).WithMany().Map(m => m.MapKey("CODIGO"));


            modelBuilder.Entity<Operacao>()
                .Property(operacao => operacao.Quantidade)
                .IsRequired()
                .HasColumnName("QUANTIDADE");

            modelBuilder.Entity<Operacao>()
              .Property(operacao => operacao.Data)
              .IsRequired()
              .HasColumnName("DATA");

            modelBuilder.Entity<Operacao>()
                .Property(operacao => operacao.Valor)
                .IsRequired()
                .HasColumnName("VALOR");

            modelBuilder.Entity<Operacao>()
                .Property(operacao => operacao.Tipo)
                .IsRequired()
                .HasColumnName("TIPO");

            modelBuilder.Entity<Operacao>().ToTable("OPERACAO");
        }
    }
}
