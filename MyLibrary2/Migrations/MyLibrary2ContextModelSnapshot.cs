﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyLibrary2.Context;

#nullable disable

namespace MyLibrary2.Migrations
{
    [DbContext(typeof(MyLibrary2Context))]
    partial class MyLibrary2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("MyLibrary2.Model.Autor", b =>
                {
                    b.Property<int>("AutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AutorId"));

                    b.Property<DateOnly>("Data_nasc")
                        .HasColumnType("date");

                    b.Property<string>("Nacionalidade")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("AutorId");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("MyLibrary2.Model.Editora", b =>
                {
                    b.Property<int>("EditoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("EditoraId"));

                    b.Property<string>("Endereco")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("EditoraId");

                    b.ToTable("Editoras");
                });

            modelBuilder.Entity("MyLibrary2.Model.Emprestimo", b =>
                {
                    b.Property<int>("EmprestimoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("EmprestimoId"));

                    b.Property<DateTime>("Data_devolucao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Data_emprestimo")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("EmprestimoId");

                    b.HasIndex("LivroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Emprestimos");
                });

            modelBuilder.Entity("MyLibrary2.Model.Genero", b =>
                {
                    b.Property<int>("GeneroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("GeneroId"));

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("GeneroId");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("MyLibrary2.Model.Livro", b =>
                {
                    b.Property<int>("LivroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("LivroId"));

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Data_publi")
                        .HasColumnType("date");

                    b.Property<int>("EditoraId")
                        .HasColumnType("int");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("LivroId");

                    b.HasIndex("AutorId");

                    b.HasIndex("EditoraId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("MyLibrary2.Model.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Endereco")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("MyLibrary2.Model.Emprestimo", b =>
                {
                    b.HasOne("MyLibrary2.Model.Livro", "Livro")
                        .WithMany("Emprestimos")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyLibrary2.Model.Usuario", "Usuario")
                        .WithMany("Emprestimos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livro");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("MyLibrary2.Model.Livro", b =>
                {
                    b.HasOne("MyLibrary2.Model.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyLibrary2.Model.Editora", "Editora")
                        .WithMany("Livros")
                        .HasForeignKey("EditoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyLibrary2.Model.Genero", "Genero")
                        .WithMany("Livros")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Editora");

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("MyLibrary2.Model.Autor", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("MyLibrary2.Model.Editora", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("MyLibrary2.Model.Genero", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("MyLibrary2.Model.Livro", b =>
                {
                    b.Navigation("Emprestimos");
                });

            modelBuilder.Entity("MyLibrary2.Model.Usuario", b =>
                {
                    b.Navigation("Emprestimos");
                });
#pragma warning restore 612, 618
        }
    }
}