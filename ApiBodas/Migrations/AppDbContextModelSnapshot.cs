﻿// <auto-generated />
using System;
using ApiBodas.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiBodas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Agencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasMaxLength(50);

                    b.Property<string>("Nombre")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Agencias");
                });

            modelBuilder.Entity("Entities.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgenciaId");

                    b.Property<int>("BackUpId");

                    b.Property<decimal>("Comision")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("CoordinadorId");

                    b.Property<int>("CordinadorId");

                    b.Property<string>("CorreoAgencia")
                        .HasMaxLength(50);

                    b.Property<string>("CorreoPareja")
                        .HasMaxLength(50);

                    b.Property<decimal>("Deposito")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18, 2)")
                        .HasDefaultValue(0m);

                    b.Property<int>("EjecutivoId");

                    b.Property<int>("EstadoAgenda");

                    b.Property<DateTime>("FechaBoda")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("FechaConfirmada")
                        .HasColumnType("Date");

                    b.Property<DateTime>("FechaLlegada")
                        .HasColumnType("Date");

                    b.Property<DateTime>("FechaMod");

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("Date");

                    b.Property<DateTime>("FechaReg");

                    b.Property<DateTime>("FechaSelloAuditoria")
                        .HasColumnType("Date");

                    b.Property<string>("HoraBoda")
                        .HasMaxLength(20);

                    b.Property<int>("HotelId");

                    b.Property<int>("LugarCenaId");

                    b.Property<int>("LugarCeremoniaId");

                    b.Property<string>("Nacionalidad")
                        .HasMaxLength(3);

                    b.Property<string>("NombreAgente")
                        .HasMaxLength(50);

                    b.Property<string>("NombrePareja")
                        .HasMaxLength(50);

                    b.Property<string>("NumReserva")
                        .HasMaxLength(25);

                    b.Property<int>("PaqueteId");

                    b.Property<int>("PaxAdultos");

                    b.Property<int>("PaxBebes");

                    b.Property<int>("PaxMenores");

                    b.Property<string>("Promocion")
                        .HasMaxLength(20);

                    b.Property<int>("TipoCereminiaId");

                    b.Property<int?>("TipoCeremoniaId");

                    b.Property<int>("UsuarioId");

                    b.Property<int>("UsuarioMod");

                    b.HasKey("Id");

                    b.HasIndex("AgenciaId");

                    b.HasIndex("BackUpId");

                    b.HasIndex("CoordinadorId");

                    b.HasIndex("EjecutivoId");

                    b.HasIndex("HotelId");

                    b.HasIndex("LugarCenaId");

                    b.HasIndex("LugarCeremoniaId");

                    b.HasIndex("PaqueteId");

                    b.HasIndex("TipoCeremoniaId");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("Entities.Models.BackUp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HotelId");

                    b.Property<string>("Lugar")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("BackUps");
                });

            modelBuilder.Entity("Entities.Models.CategoriaServicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("CategoriasServicios");
                });

            modelBuilder.Entity("Entities.Models.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgendaId");

                    b.Property<string>("Comentarios")
                        .HasMaxLength(150);

                    b.Property<DateTime>("FechaReg");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("Entities.Models.Coordinador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HotelId");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Cordinadores");
                });

            modelBuilder.Entity("Entities.Models.DiasBloqueados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo");

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("HoraFinal")
                        .HasMaxLength(20);

                    b.Property<string>("HoraInicio")
                        .HasMaxLength(20);

                    b.Property<int>("HotelId");

                    b.Property<string>("Locacion")
                        .HasMaxLength(20);

                    b.Property<bool>("Parcial");

                    b.HasKey("Id");

                    b.ToTable("DiasBloquedo");
                });

            modelBuilder.Entity("Entities.Models.Ejecutivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Iniciales")
                        .HasMaxLength(10);

                    b.Property<string>("Nombre")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Ejecutivos");
                });

            modelBuilder.Entity("Entities.Models.Historial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgendaId");

                    b.Property<DateTime>("FechaReg");

                    b.Property<int>("IdUsuario");

                    b.Property<string>("ValorAnterior")
                        .HasMaxLength(50);

                    b.Property<string>("ValorNuevo")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("historial");
                });

            modelBuilder.Entity("Entities.Models.Horas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hora")
                        .HasMaxLength(20);

                    b.Property<int>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Horas");
                });

            modelBuilder.Entity("Entities.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Clave")
                        .HasMaxLength(150);

                    b.Property<string>("Img")
                        .HasMaxLength(150);

                    b.Property<string>("Nombre")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Hoteles");
                });

            modelBuilder.Entity("Entities.Models.LugarCena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HotelId");

                    b.Property<string>("Lugar")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("LugaresCena");
                });

            modelBuilder.Entity("Entities.Models.LugarCeremonia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HotelId");

                    b.Property<string>("Lugar")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("LugaresCeremonia");
                });

            modelBuilder.Entity("Entities.Models.MasterFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hotel");

                    b.HasKey("Id");

                    b.ToTable("MasterFile");
                });

            modelBuilder.Entity("Entities.Models.MasterFileContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad");

                    b.Property<string>("Img")
                        .HasMaxLength(150);

                    b.Property<int>("MasterFileId");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ServicioId");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("MasterFileContenido");
                });

            modelBuilder.Entity("Entities.Models.Paquete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo");

                    b.Property<string>("Clave")
                        .HasMaxLength(50);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Paquetes");
                });

            modelBuilder.Entity("Entities.Models.PaqueteServicio", b =>
                {
                    b.Property<int>("PaqueteId");

                    b.Property<int>("ServicioId");

                    b.HasKey("PaqueteId", "ServicioId");

                    b.HasIndex("ServicioId");

                    b.ToTable("PaqueteServicio");
                });

            modelBuilder.Entity("Entities.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Entities.Models.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaServicioId");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(150);

                    b.Property<string>("Img")
                        .HasMaxLength(250);

                    b.Property<string>("Nota")
                        .HasMaxLength(150);

                    b.Property<decimal>("PrecioSugerido")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaServicioId");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("Entities.Models.TipoCeremonia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TiposCeremonia");
                });

            modelBuilder.Entity("Entities.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasMaxLength(50);

                    b.Property<string>("Hoteles")
                        .HasMaxLength(50);

                    b.Property<string>("Img")
                        .HasMaxLength(250);

                    b.Property<string>("Nombre")
                        .HasMaxLength(50);

                    b.Property<string>("Password");

                    b.Property<int>("RoleId");

                    b.Property<string>("UserName")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Entities.Models.Agenda", b =>
                {
                    b.HasOne("Entities.Models.Agencia", "Agencia")
                        .WithMany()
                        .HasForeignKey("AgenciaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entities.Models.BackUp", "BackUp")
                        .WithMany("Agendas")
                        .HasForeignKey("BackUpId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entities.Models.Coordinador", "Coordinador")
                        .WithMany()
                        .HasForeignKey("CoordinadorId");

                    b.HasOne("Entities.Models.Ejecutivo", "Ejecutivo")
                        .WithMany()
                        .HasForeignKey("EjecutivoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entities.Models.Hotel", "Hotel")
                        .WithMany("Agendas")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entities.Models.LugarCena", "LugarCena")
                        .WithMany("Agendas")
                        .HasForeignKey("LugarCenaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entities.Models.LugarCeremonia", "LugarCeremonia")
                        .WithMany("Agendas")
                        .HasForeignKey("LugarCeremoniaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entities.Models.Paquete", "Paquete")
                        .WithMany()
                        .HasForeignKey("PaqueteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entities.Models.TipoCeremonia", "TipoCeremonia")
                        .WithMany()
                        .HasForeignKey("TipoCeremoniaId");
                });

            modelBuilder.Entity("Entities.Models.BackUp", b =>
                {
                    b.HasOne("Entities.Models.Hotel", "Hotel")
                        .WithMany("BackUps")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.Models.Coordinador", b =>
                {
                    b.HasOne("Entities.Models.Hotel", "Hotel")
                        .WithMany("Coordinadores")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.Models.LugarCena", b =>
                {
                    b.HasOne("Entities.Models.Hotel", "Hotel")
                        .WithMany("LugaresCena")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.Models.LugarCeremonia", b =>
                {
                    b.HasOne("Entities.Models.Hotel", "Hotel")
                        .WithMany("LugaresCeremonia")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.Models.PaqueteServicio", b =>
                {
                    b.HasOne("Entities.Models.Paquete", "Paquete")
                        .WithMany("PaqueteServicios")
                        .HasForeignKey("PaqueteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entities.Models.Servicio", "Servicio")
                        .WithMany()
                        .HasForeignKey("ServicioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.Models.Servicio", b =>
                {
                    b.HasOne("Entities.Models.CategoriaServicio", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaServicioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.Models.Usuario", b =>
                {
                    b.HasOne("Entities.Models.Role", "Role")
                        .WithMany("Usuarios")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}