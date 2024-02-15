﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240201113605_FirstTable")]
    partial class FirstTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.Entities.Commande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCommande")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdCreateur")
                        .HasColumnType("int");

                    b.Property<DateTime>("LasetUpdate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MontantHT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MontantTTC")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RefCommande")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Taxe")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Com_Commande", "dbo");
                });

            modelBuilder.Entity("Data.Entities.CommandeDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCommande")
                        .HasColumnType("int");

                    b.Property<int>("IdCreateur")
                        .HasColumnType("int");

                    b.Property<int>("IdProduit")
                        .HasColumnType("int");

                    b.Property<DateTime>("LasetUpdate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Montant")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PU")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qnt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCommande");

                    b.ToTable("Com_CommandeDetail", "dbo");
                });

            modelBuilder.Entity("Data.Entities.Produit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCreateur")
                        .HasColumnType("int");

                    b.Property<DateTime>("LasetUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Prix")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Pr_Produit", "dbo");
                });

            modelBuilder.Entity("Data.Entities.CommandeDetail", b =>
                {
                    b.HasOne("Data.Entities.Commande", "Commandes")
                        .WithMany("CommandeDetails")
                        .HasForeignKey("IdCommande")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commandes");
                });

            modelBuilder.Entity("Data.Entities.Commande", b =>
                {
                    b.Navigation("CommandeDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
