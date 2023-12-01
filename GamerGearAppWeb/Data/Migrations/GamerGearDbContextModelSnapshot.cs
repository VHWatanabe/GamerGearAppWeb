﻿// <auto-generated />
using System;
using GamerGearAppWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GamerGearAppWeb.Data.Migrations
{
    [DbContext(typeof(GamerGearDbContext))]
    partial class GamerGearDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GamerGearAppWeb.Models.Periferico", b =>
                {
                    b.Property<int>("PerifericoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PerifericoId"));

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("EntregaGratis")
                        .HasColumnType("bit");

                    b.Property<int>("Estoque")
                        .HasColumnType("int");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<DateTime>("PrecoValido")
                        .HasColumnType("datetime2");

                    b.HasKey("PerifericoId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Periferico");
                });

            modelBuilder.Entity("GamerGearAppWeb.models.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarcaId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("GamerGearAppWeb.Models.Periferico", b =>
                {
                    b.HasOne("GamerGearAppWeb.models.Marca", null)
                        .WithMany("Perifericos")
                        .HasForeignKey("MarcaId");
                });

            modelBuilder.Entity("GamerGearAppWeb.models.Marca", b =>
                {
                    b.Navigation("Perifericos");
                });
#pragma warning restore 612, 618
        }
    }
}
