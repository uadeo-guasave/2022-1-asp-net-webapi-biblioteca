﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiBiblioteca;

#nullable disable

namespace WebApiBiblioteca.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
#pragma warning restore 612, 618
        }
    }
}
