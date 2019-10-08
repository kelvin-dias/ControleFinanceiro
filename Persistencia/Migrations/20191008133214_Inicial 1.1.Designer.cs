﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia.Context;

namespace Persistencia.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20191008133214_Inicial 1.1")]
    partial class Inicial11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo.Entidades.DespesaDia", b =>
                {
                    b.Property<int?>("DespesaDiaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria");

                    b.Property<DateTime>("DataHora");

                    b.Property<string>("NomeItem");

                    b.Property<decimal>("Valor");

                    b.HasKey("DespesaDiaId");

                    b.ToTable("DESPESAS_DIA");
                });

            modelBuilder.Entity("Modelo.Entidades.DespesaMensal", b =>
                {
                    b.Property<int?>("DespesaMensalId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHora");

                    b.Property<string>("NomeItem");

                    b.Property<decimal>("Valor");

                    b.HasKey("DespesaMensalId");

                    b.ToTable("DESPESAS_MENSAIS");
                });

            modelBuilder.Entity("Modelo.Entidades.DespesaParcelada", b =>
                {
                    b.Property<int?>("DespesaParceladaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria");

                    b.Property<DateTime>("DataHora");

                    b.Property<string>("NomeItem");

                    b.Property<int>("QuantidadeParcela");

                    b.Property<bool>("StatusPagamento");

                    b.Property<decimal>("Valor");

                    b.Property<double>("ValorParcela");

                    b.HasKey("DespesaParceladaId");

                    b.ToTable("DESPESAS_PARCELADAS");
                });

            modelBuilder.Entity("Modelo.Entidades.ReceitaAdicional", b =>
                {
                    b.Property<int?>("ReceitaAdicionalId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHora");

                    b.Property<string>("NomeItem");

                    b.Property<string>("TipoReceita");

                    b.Property<decimal>("Valor");

                    b.HasKey("ReceitaAdicionalId");

                    b.ToTable("RECEITAS_ADICIONAIS");
                });

            modelBuilder.Entity("Modelo.Entidades.ReceitaMensal", b =>
                {
                    b.Property<int?>("ReceitaMensalId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHora");

                    b.Property<string>("NomeReceita");

                    b.Property<string>("TipoReceita");

                    b.Property<decimal>("Valor");

                    b.HasKey("ReceitaMensalId");

                    b.ToTable("RECEITAS_MENSAIS");
                });

            modelBuilder.Entity("Modelo.Tabelas.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoginUsuario")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SobrenomeUsuario")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("UsuarioId");

                    b.ToTable("USUARIOS");
                });
#pragma warning restore 612, 618
        }
    }
}
