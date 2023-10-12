﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoDimDim.Data;

#nullable disable

namespace ProjetoDimDim.Migrations
{
    [DbContext(typeof(ProjetoDDContext))]
    partial class ProjetoDDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjetoDimDim.Models.Implantacao", b =>
                {
                    b.Property<int>("ImplantacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImplantacaoId"));

                    b.Property<int>("ProjetoId")
                        .HasColumnType("int");

                    b.Property<string>("ServicoNuvem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusImplantacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VersaoDocker")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImplantacaoId");

                    b.HasIndex("ProjetoId");

                    b.ToTable("Implantacoes");
                });

            modelBuilder.Entity("ProjetoDimDim.Models.Projeto", b =>
                {
                    b.Property<int>("ProjetoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjetoId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dificuldade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjetoId");

                    b.ToTable("Projetos");
                });

            modelBuilder.Entity("ProjetoDimDim.Models.Implantacao", b =>
                {
                    b.HasOne("ProjetoDimDim.Models.Projeto", "Projeto")
                        .WithMany("implantacoes")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Projeto");
                });

            modelBuilder.Entity("ProjetoDimDim.Models.Projeto", b =>
                {
                    b.Navigation("implantacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
