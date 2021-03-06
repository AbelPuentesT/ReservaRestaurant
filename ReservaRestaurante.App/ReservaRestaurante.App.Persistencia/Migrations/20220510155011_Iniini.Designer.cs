// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReservaRestaurante.App.Persistencia.Context;

#nullable disable

namespace ReservaRestaurante.App.Persistencia.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220510155011_Iniini")]
    partial class Iniini
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ReservaRestaurante.App.Dominio.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Cedula")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Cedula")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ReservaRestaurante.App.Dominio.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<string>("ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("numero")
                        .IsUnique();

                    b.ToTable("Mesas");
                });

            modelBuilder.Entity("ReservaRestaurante.App.Dominio.Mesero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Cedula")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Cedula")
                        .IsUnique();

                    b.ToTable("Meseros");
                });

            modelBuilder.Entity("ReservaRestaurante.App.Dominio.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("clienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("mesaId")
                        .HasColumnType("int");

                    b.Property<int>("meseroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("clienteId");

                    b.HasIndex("mesaId");

                    b.HasIndex("meseroId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("ReservaRestaurante.App.Dominio.Reserva", b =>
                {
                    b.HasOne("ReservaRestaurante.App.Dominio.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReservaRestaurante.App.Dominio.Mesa", "mesa")
                        .WithMany()
                        .HasForeignKey("mesaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReservaRestaurante.App.Dominio.Mesero", "mesero")
                        .WithMany()
                        .HasForeignKey("meseroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");

                    b.Navigation("mesa");

                    b.Navigation("mesero");
                });
#pragma warning restore 612, 618
        }
    }
}
