using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data.Configuration;
  /*   public class EntidadConfiguration: IEntityTypeConfiguration<Entidad>
    {
         public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.ToTable("Areas");

            builder.Property(p => p.Descripcion)
            .HasMaxLength(200);

            builder.HasOne(p => p.)
            .WithMany(p => p.)
            .HasForeignKey(p => p.);

             builder.HasOne(p => p.Persona)
            .WithOne()
            .HasForeignKey<Usuario>(p => p.IdPersona);

             builder.HasKey(p => new { p.IdPersona, p.IdContacto });

             builder.Property(p => p.Total)
             .HasPrecision(65,5)
             .IsRequired();

            builder.HasKey(e => e.);
            builder.Property(e => e.)
            .ValueGeneratedNever();   

            
        }
    } */
