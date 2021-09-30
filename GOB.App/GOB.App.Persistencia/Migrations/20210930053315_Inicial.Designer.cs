﻿// <auto-generated />
using System;
using GOB.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GOB.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210930053315_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GOB.App.Dominio.Aislamiento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("fechaDiagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaRetorno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("periodoAislamiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sintomas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("aislamiento");
                });

            modelBuilder.Entity("GOB.App.Dominio.Gobernacion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("maxNumeroIngresos")
                        .HasColumnType("int");

                    b.Property<int>("numeroSedes")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("gobernacion");
                });

            modelBuilder.Entity("GOB.App.Dominio.GobernadorAsesores", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<int>("estadoSalud")
                        .HasColumnType("int");

                    b.Property<int>("identificacion")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("gobernadores");
                });

            modelBuilder.Entity("GOB.App.Dominio.Ingreso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("estadoIngreso")
                        .HasColumnType("int");

                    b.Property<DateTime>("horaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("horaSalida")
                        .HasColumnType("datetime2");

                    b.Property<string>("oficinaIngreso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sedeIngreso")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ingreso");
                });

            modelBuilder.Entity("GOB.App.Dominio.Oficina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("GobernadorAsesoresid")
                        .HasColumnType("int");

                    b.Property<int>("estadoOficina")
                        .HasColumnType("int");

                    b.Property<string>("numeroOficina")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("GobernadorAsesoresid");

                    b.ToTable("oficina");
                });

            modelBuilder.Entity("GOB.App.Dominio.PersonalAseo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<int>("estadoSalud")
                        .HasColumnType("int");

                    b.Property<int>("identificacion")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("turno")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("personal");
                });

            modelBuilder.Entity("GOB.App.Dominio.Proveedor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<int>("estadoSalud")
                        .HasColumnType("int");

                    b.Property<int>("identificacion")
                        .HasColumnType("int");

                    b.Property<string>("lugarServicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servicio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("proveedor");
                });

            modelBuilder.Entity("GOB.App.Dominio.SecretariosDespacho", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("despacho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<int>("estadoSalud")
                        .HasColumnType("int");

                    b.Property<int>("identificacion")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("SecretariosDespacho");
                });

            modelBuilder.Entity("GOB.App.Dominio.Sedes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("GobernadorAsesoresid")
                        .HasColumnType("int");

                    b.Property<int>("numeroOficinas")
                        .HasColumnType("int");

                    b.Property<string>("numeroSede")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("GobernadorAsesoresid");

                    b.ToTable("sedes");
                });

            modelBuilder.Entity("GOB.App.Dominio.Oficina", b =>
                {
                    b.HasOne("GOB.App.Dominio.GobernadorAsesores", null)
                        .WithMany("oficinasVisitadas")
                        .HasForeignKey("GobernadorAsesoresid");
                });

            modelBuilder.Entity("GOB.App.Dominio.Sedes", b =>
                {
                    b.HasOne("GOB.App.Dominio.GobernadorAsesores", null)
                        .WithMany("sedesVisitadas")
                        .HasForeignKey("GobernadorAsesoresid");
                });

            modelBuilder.Entity("GOB.App.Dominio.GobernadorAsesores", b =>
                {
                    b.Navigation("oficinasVisitadas");

                    b.Navigation("sedesVisitadas");
                });
#pragma warning restore 612, 618
        }
    }
}
