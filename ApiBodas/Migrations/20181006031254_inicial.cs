using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiBodas.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agencias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true),
                    Correo = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriasServicios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasServicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgendaId = table.Column<int>(nullable: false),
                    Comentarios = table.Column<string>(maxLength: 150, nullable: true),
                    UsuarioId = table.Column<int>(nullable: false),
                    FechaReg = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiasBloquedo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Parcial = table.Column<bool>(nullable: false),
                    HoraInicio = table.Column<string>(maxLength: 20, nullable: true),
                    HoraFinal = table.Column<string>(maxLength: 20, nullable: true),
                    Locacion = table.Column<string>(maxLength: 20, nullable: true),
                    HotelId = table.Column<int>(nullable: false),
                    Activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiasBloquedo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ejecutivos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true),
                    Iniciales = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejecutivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "historial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgendaId = table.Column<int>(nullable: false),
                    ValorAnterior = table.Column<string>(maxLength: 50, nullable: true),
                    ValorNuevo = table.Column<string>(maxLength: 50, nullable: true),
                    IdUsuario = table.Column<int>(nullable: false),
                    FechaReg = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Horas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hora = table.Column<string>(maxLength: 20, nullable: true),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hoteles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 150, nullable: true),
                    Clave = table.Column<string>(maxLength: 150, nullable: true),
                    Img = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoteles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterFile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hotel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterFile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterFileContenido",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MasterFileId = table.Column<int>(nullable: false),
                    ServicioId = table.Column<int>(nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Img = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterFileContenido", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paquetes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 150, nullable: true),
                    Clave = table.Column<string>(maxLength: 50, nullable: true),
                    Activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paquetes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposCeremonia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposCeremonia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 150, nullable: true),
                    PrecioSugerido = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Nota = table.Column<string>(maxLength: 150, nullable: true),
                    Img = table.Column<string>(maxLength: 250, nullable: true),
                    CategoriaServicioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicios_CategoriasServicios_CategoriaServicioId",
                        column: x => x.CategoriaServicioId,
                        principalTable: "CategoriasServicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BackUps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lugar = table.Column<string>(maxLength: 150, nullable: true),
                    HotelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackUps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BackUps_Hoteles_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hoteles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cordinadores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true),
                    HotelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cordinadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cordinadores_Hoteles_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hoteles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LugaresCena",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lugar = table.Column<string>(maxLength: 150, nullable: true),
                    HotelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LugaresCena", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LugaresCena_Hoteles_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hoteles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LugaresCeremonia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lugar = table.Column<string>(maxLength: 150, nullable: true),
                    HotelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LugaresCeremonia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LugaresCeremonia_Hoteles_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hoteles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 15, nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true),
                    Correo = table.Column<string>(maxLength: 50, nullable: true),
                    Hoteles = table.Column<string>(maxLength: 50, nullable: true),
                    Img = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaqueteServicio",
                columns: table => new
                {
                    PaqueteId = table.Column<int>(nullable: false),
                    ServicioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaqueteServicio", x => new { x.PaqueteId, x.ServicioId });
                    table.ForeignKey(
                        name: "FK_PaqueteServicio_Paquetes_PaqueteId",
                        column: x => x.PaqueteId,
                        principalTable: "Paquetes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaqueteServicio_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EstadoAgenda = table.Column<int>(nullable: false),
                    EjecutivoId = table.Column<int>(nullable: false),
                    FechaConfirmada = table.Column<DateTime>(type: "Date", nullable: false),
                    CordinadorId = table.Column<int>(nullable: false),
                    FechaBoda = table.Column<DateTime>(type: "Date", nullable: false),
                    HoraBoda = table.Column<string>(maxLength: 20, nullable: true),
                    LugarCeremoniaId = table.Column<int>(nullable: false),
                    LugarCenaId = table.Column<int>(nullable: false),
                    BackUpId = table.Column<int>(nullable: false),
                    TipoCereminiaId = table.Column<int>(nullable: false),
                    PaxAdultos = table.Column<int>(nullable: false),
                    PaxMenores = table.Column<int>(nullable: false),
                    PaxBebes = table.Column<int>(nullable: false),
                    PaqueteId = table.Column<int>(nullable: false),
                    NombrePareja = table.Column<string>(maxLength: 50, nullable: true),
                    CorreoPareja = table.Column<string>(maxLength: 50, nullable: true),
                    Nacionalidad = table.Column<string>(maxLength: 3, nullable: true),
                    NombreAgente = table.Column<string>(maxLength: 50, nullable: true),
                    AgenciaId = table.Column<int>(nullable: false),
                    CorreoAgencia = table.Column<string>(maxLength: 50, nullable: true),
                    Deposito = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    NumReserva = table.Column<string>(maxLength: 25, nullable: true),
                    Promocion = table.Column<string>(maxLength: 20, nullable: true),
                    Comision = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    FechaSelloAuditoria = table.Column<DateTime>(nullable: false),
                    FechaPago = table.Column<DateTime>(nullable: false),
                    FechaLlegada = table.Column<DateTime>(nullable: false),
                    HotelId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    FechaReg = table.Column<DateTime>(nullable: false),
                    UsuarioMod = table.Column<int>(nullable: false),
                    FechaMod = table.Column<DateTime>(nullable: false),
                    CoordinadorId = table.Column<int>(nullable: true),
                    TipoCeremoniaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendas_Agencias_AgenciaId",
                        column: x => x.AgenciaId,
                        principalTable: "Agencias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendas_BackUps_BackUpId",
                        column: x => x.BackUpId,
                        principalTable: "BackUps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendas_Cordinadores_CoordinadorId",
                        column: x => x.CoordinadorId,
                        principalTable: "Cordinadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agendas_Ejecutivos_EjecutivoId",
                        column: x => x.EjecutivoId,
                        principalTable: "Ejecutivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendas_Hoteles_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hoteles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agendas_LugaresCena_LugarCenaId",
                        column: x => x.LugarCenaId,
                        principalTable: "LugaresCena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agendas_LugaresCeremonia_LugarCeremoniaId",
                        column: x => x.LugarCeremoniaId,
                        principalTable: "LugaresCeremonia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agendas_Paquetes_PaqueteId",
                        column: x => x.PaqueteId,
                        principalTable: "Paquetes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendas_TiposCeremonia_TipoCeremoniaId",
                        column: x => x.TipoCeremoniaId,
                        principalTable: "TiposCeremonia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_AgenciaId",
                table: "Agendas",
                column: "AgenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_BackUpId",
                table: "Agendas",
                column: "BackUpId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_CoordinadorId",
                table: "Agendas",
                column: "CoordinadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_EjecutivoId",
                table: "Agendas",
                column: "EjecutivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_HotelId",
                table: "Agendas",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_LugarCenaId",
                table: "Agendas",
                column: "LugarCenaId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_LugarCeremoniaId",
                table: "Agendas",
                column: "LugarCeremoniaId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_PaqueteId",
                table: "Agendas",
                column: "PaqueteId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_TipoCeremoniaId",
                table: "Agendas",
                column: "TipoCeremoniaId");

            migrationBuilder.CreateIndex(
                name: "IX_BackUps_HotelId",
                table: "BackUps",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cordinadores_HotelId",
                table: "Cordinadores",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_LugaresCena_HotelId",
                table: "LugaresCena",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_LugaresCeremonia_HotelId",
                table: "LugaresCeremonia",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_PaqueteServicio_ServicioId",
                table: "PaqueteServicio",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_CategoriaServicioId",
                table: "Servicios",
                column: "CategoriaServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RoleId",
                table: "Usuarios",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "DiasBloquedo");

            migrationBuilder.DropTable(
                name: "historial");

            migrationBuilder.DropTable(
                name: "Horas");

            migrationBuilder.DropTable(
                name: "MasterFile");

            migrationBuilder.DropTable(
                name: "MasterFileContenido");

            migrationBuilder.DropTable(
                name: "PaqueteServicio");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Agencias");

            migrationBuilder.DropTable(
                name: "BackUps");

            migrationBuilder.DropTable(
                name: "Cordinadores");

            migrationBuilder.DropTable(
                name: "Ejecutivos");

            migrationBuilder.DropTable(
                name: "LugaresCena");

            migrationBuilder.DropTable(
                name: "LugaresCeremonia");

            migrationBuilder.DropTable(
                name: "TiposCeremonia");

            migrationBuilder.DropTable(
                name: "Paquetes");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Hoteles");

            migrationBuilder.DropTable(
                name: "CategoriasServicios");
        }
    }
}
