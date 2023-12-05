using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMid.Migrations
{
    public partial class FluentApiConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Midle",
                columns: table => new
                {
                    MidleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Request = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FechaRequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FechaResponse = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Midle", x => x.MidleID);
                });

            migrationBuilder.InsertData(
                table: "Midle",
                columns: new[] { "MidleID", "FechaRequest", "FechaResponse", "Request", "Response", "Usuario" },
                values: new object[] { new Guid("37ccf25f-b150-469c-be53-330a2daf86fc"), new DateTime(2023, 12, 5, 14, 21, 8, 297, DateTimeKind.Local).AddTicks(4366), new DateTime(2023, 12, 5, 14, 21, 8, 297, DateTimeKind.Local).AddTicks(4368), "/programa/algoritmo/solucion/jafgyA,Ara%20Escobedo", "{ result = fg }", "Ara Escobedo" });

            migrationBuilder.InsertData(
                table: "Midle",
                columns: new[] { "MidleID", "FechaRequest", "FechaResponse", "Request", "Response", "Usuario" },
                values: new object[] { new Guid("93e8d162-ea68-414f-9c33-7c5e2758d79b"), new DateTime(2023, 12, 5, 14, 21, 8, 297, DateTimeKind.Local).AddTicks(4306), new DateTime(2023, 12, 5, 14, 21, 8, 297, DateTimeKind.Local).AddTicks(4329), "/programa/algoritmo/solucion/n3urcaVsw4r7,Oscar%20Mejia", "{ result = aV }", "Oscar Mejia" });

            migrationBuilder.InsertData(
                table: "Midle",
                columns: new[] { "MidleID", "FechaRequest", "FechaResponse", "Request", "Response", "Usuario" },
                values: new object[] { new Guid("f80f584c-b227-4675-bd1d-9f95c61b4884"), new DateTime(2023, 12, 5, 14, 21, 8, 297, DateTimeKind.Local).AddTicks(4358), new DateTime(2023, 12, 5, 14, 21, 8, 297, DateTimeKind.Local).AddTicks(4360), "/programa/algoritmo/solucion/Qc1uoTgfd,Paola%Gutierrez", "{ result = o }", "Paola Gutierrez" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Midle");
        }
    }
}
