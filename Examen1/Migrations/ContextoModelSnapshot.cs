﻿// <auto-generated />
using System;
using Examen1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Examen2.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("Examen2.Entidades.Proyectos", b =>
                {
                    b.Property<int>("proyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("descripcionproyecto")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("TEXT");

                    b.HasKey("proyectoId");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("Examen2.Entidades.TareaDetalle", b =>
                {
                    b.Property<int>("tipoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("requerimiento")
                        .HasColumnType("TEXT");

                    b.Property<int>("tiempo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("tipoTarea")
                        .HasColumnType("TEXT");

                    b.HasKey("tipoId");

                    b.ToTable("TareaDetalle");
                });

            modelBuilder.Entity("Examen2.Entidades.TareaDetalle", b =>
                {
                    b.HasOne("Examen2.Entidades.Proyectos", "proyectos")
                        .WithMany("Detalle")
                        .HasForeignKey("tipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
