using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiBodas.Migrations
{
    public partial class inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaSelloAuditoria",
                table: "Agendas",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaPago",
                table: "Agendas",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaLlegada",
                table: "Agendas",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaConfirmada",
                table: "Agendas",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<decimal>(
                name: "Deposito",
                table: "Agendas",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaSelloAuditoria",
                table: "Agendas",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaPago",
                table: "Agendas",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaLlegada",
                table: "Agendas",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaConfirmada",
                table: "Agendas",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Deposito",
                table: "Agendas",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldDefaultValue: 0m);
        }
    }
}
