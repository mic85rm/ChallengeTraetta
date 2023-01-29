﻿// <auto-generated />
using ChallengeTraetta.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChallengeTraetta.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20230129000103_Migrationv1")]
    partial class Migrationv1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChallengeTraetta.Models.CategoriaMerceologica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoriaMerceologica");
                });

            modelBuilder.Entity("ChallengeTraetta.Models.Compagnia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCompagnia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Compagnia");
                });

            modelBuilder.Entity("ChallengeTraetta.Models.Indirizzo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompagniaID")
                        .HasColumnType("int");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NCivico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Via")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompagniaID");

                    b.ToTable("Indirizzo");
                });

            modelBuilder.Entity("ChallengeTraetta.Models.MezzoDiContatto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IndirizzoID")
                        .HasColumnType("int");

                    b.Property<int>("TipoContattoID")
                        .HasColumnType("int");

                    b.Property<string>("Valore")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IndirizzoID");

                    b.HasIndex("TipoContattoID");

                    b.ToTable("MezzoDiContatto");
                });

            modelBuilder.Entity("ChallengeTraetta.Models.Prodotto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaMerceologicaId")
                        .HasColumnType("int");

                    b.Property<int>("CompagniaID")
                        .HasColumnType("int");

                    b.Property<string>("NomeProdotto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantitaProdotto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaMerceologicaId");

                    b.ToTable("Prodotto");
                });

            modelBuilder.Entity("ChallengeTraetta.Models.TipoContatto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoContatto");
                });

            modelBuilder.Entity("ChallengeTraetta.Models.Indirizzo", b =>
                {
                    b.HasOne("ChallengeTraetta.Models.Compagnia", "Compagnia")
                        .WithMany()
                        .HasForeignKey("CompagniaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compagnia");
                });

            modelBuilder.Entity("ChallengeTraetta.Models.MezzoDiContatto", b =>
                {
                    b.HasOne("ChallengeTraetta.Models.Indirizzo", "Indirizzo")
                        .WithMany()
                        .HasForeignKey("IndirizzoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChallengeTraetta.Models.TipoContatto", "TipoContatto")
                        .WithMany()
                        .HasForeignKey("TipoContattoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Indirizzo");

                    b.Navigation("TipoContatto");
                });

            modelBuilder.Entity("ChallengeTraetta.Models.Prodotto", b =>
                {
                    b.HasOne("ChallengeTraetta.Models.CategoriaMerceologica", "CategoriaMerceologica")
                        .WithMany()
                        .HasForeignKey("CategoriaMerceologicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriaMerceologica");
                });
#pragma warning restore 612, 618
        }
    }
}
