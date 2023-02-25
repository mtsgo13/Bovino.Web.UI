using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bovino.Models.Entities;

namespace Bovino.Application.EntityConfiguration
{
    public class BovinoConfiguration : IEntityTypeConfiguration<BovinoModel>
    {
        public void Configure(EntityTypeBuilder<BovinoModel> builder)
        {
            builder.ToTable("Bovinos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Brinco).HasMaxLength(8).IsRequired();
            builder.Property(x => x.Situacao).HasMaxLength(15);
            builder.Property(x => x.Sexo).HasMaxLength(1);
            builder.Property(x => x.BrincoMae).HasMaxLength(8);
            builder.Property(x => x.BrincoPai).HasMaxLength(8);
            builder.Property(x => x.Raca).HasMaxLength(15);
            builder.Property(x => x.DataNascimento);
            builder.Property(x => x.DataPrenhes);
            builder.Property(x => x.DataUltimoParto);
            
        }
    }
}
