﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiBiblioteca;

#nullable disable

namespace WebApiBiblioteca.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221027140432_CreateTableUsuarios")]
    partial class CreateTableUsuarios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("WebApiBiblioteca.Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("WebApiBiblioteca.Models.Editorial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Domicilio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Editoriales");
                });

            modelBuilder.Entity("WebApiBiblioteca.Models.Ejemplar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Condiciones")
                        .HasColumnType("TEXT");

                    b.Property<double>("Costo")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("FechaDeIngreso")
                        .HasColumnType("TEXT");

                    b.Property<int>("LibroId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LibroId");

                    b.ToTable("Ejemplares");
                });

            modelBuilder.Entity("WebApiBiblioteca.Models.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AutorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Edicion")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EditorialId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("EditorialId");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("WebApiBiblioteca.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .HasColumnType("TEXT");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Contraseña")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Recordatorio")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("WebApiBiblioteca.Models.Ejemplar", b =>
                {
                    b.HasOne("WebApiBiblioteca.Models.Libro", "Libro")
                        .WithMany("Ejemplares")
                        .HasForeignKey("LibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Libro");
                });

            modelBuilder.Entity("WebApiBiblioteca.Models.Libro", b =>
                {
                    b.HasOne("WebApiBiblioteca.Models.Autor", "Autor")
                        .WithMany("Libros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiBiblioteca.Models.Editorial", "Editorial")
                        .WithMany("Libros")
                        .HasForeignKey("EditorialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Editorial");
                });

            modelBuilder.Entity("WebApiBiblioteca.Models.Autor", b =>
                {
                    b.Navigation("Libros");
                });

            modelBuilder.Entity("WebApiBiblioteca.Models.Editorial", b =>
                {
                    b.Navigation("Libros");
                });

            modelBuilder.Entity("WebApiBiblioteca.Models.Libro", b =>
                {
                    b.Navigation("Ejemplares");
                });
#pragma warning restore 612, 618
        }
    }
}
