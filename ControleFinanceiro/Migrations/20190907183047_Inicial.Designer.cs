﻿// <auto-generated />
using System;
using ControleFinanceiro.Persistencia.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleFinanceiro.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20190907183047_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControleFinanceiro.Models.CompraFixa", b =>
                {
                    b.Property<int?>("CompraFixaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria");

                    b.Property<DateTime>("DataHora");

                    b.Property<string>("NomeItem");

                    b.Property<double>("Valor");

                    b.HasKey("CompraFixaId");

                    b.ToTable("COMPRAS_FIXAS");
                });

            modelBuilder.Entity("ControleFinanceiro.Models.CompraMensal", b =>
                {
                    b.Property<int?>("CompraMensalId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHora");

                    b.Property<string>("NomeItem");

                    b.Property<double>("Valor");

                    b.HasKey("CompraMensalId");

                    b.ToTable("COMPRAS_MENSAIS");
                });

            modelBuilder.Entity("ControleFinanceiro.Models.CompraParcelada", b =>
                {
                    b.Property<int>("CompraParceladaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria");

                    b.Property<DateTime>("DataHora");

                    b.Property<string>("NomeItem");

                    b.Property<int>("QuantidadeParcela");

                    b.Property<bool>("StatusPagamento");

                    b.Property<double>("Valor");

                    b.Property<double>("ValorParcela");

                    b.HasKey("CompraParceladaId");

                    b.ToTable("COMPRAS_PARCELADAS");
                });
#pragma warning restore 612, 618
        }
    }
}
