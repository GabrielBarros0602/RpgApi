using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Classe",
                table: "TB_ARMAS");

            migrationBuilder.AddColumn<byte[]>(
                name: "FotoPersonagem",
                table: "TB_PERSONAGENS",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    DataAcesso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Perfil = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, defaultValue: "Jogador"),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIOS", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.InsertData(
                table: "TB_USUARIOS",
                columns: new[] { "Id", "DataAcesso", "Email", "Foto", "Latitude", "Longitude", "PasswordHash", "PasswordSalt", "Perfil", "Username" },
                values: new object[] { 1, null, "seuEmail@gmail.com", null, -23.520024100000001, -46.596497999999997, new byte[] { 10, 27, 25, 215, 225, 18, 86, 166, 230, 216, 28, 229, 217, 178, 49, 166, 55, 217, 174, 116, 143, 183, 224, 83, 157, 38, 203, 1, 28, 207, 230, 57, 57, 170, 165, 81, 174, 78, 68, 0, 131, 167, 249, 39, 248, 88, 250, 158, 216, 161, 167, 201, 228, 187, 44, 72, 2, 211, 79, 37, 52, 44, 181, 185 }, new byte[] { 76, 207, 227, 173, 233, 20, 138, 60, 43, 76, 226, 178, 49, 129, 127, 44, 127, 194, 8, 230, 93, 207, 30, 206, 127, 162, 85, 254, 86, 184, 0, 128, 52, 224, 11, 174, 108, 229, 225, 134, 6, 158, 77, 161, 206, 54, 38, 11, 184, 107, 97, 56, 88, 67, 220, 154, 183, 163, 59, 215, 207, 217, 247, 236, 242, 178, 253, 166, 173, 75, 69, 213, 130, 254, 63, 132, 177, 108, 115, 201, 187, 63, 23, 158, 235, 10, 3, 196, 128, 134, 224, 201, 145, 234, 42, 56, 184, 104, 98, 53, 58, 118, 62, 178, 59, 34, 12, 105, 208, 245, 75, 10, 98, 236, 226, 129, 193, 165, 96, 71, 76, 22, 39, 159, 148, 21, 104, 246 }, "Admin", "UsuarioAdmin" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropTable(
                name: "TB_USUARIOS");

            migrationBuilder.DropIndex(
                name: "IX_TB_PERSONAGENS_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "FotoPersonagem",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.AddColumn<int>(
                name: "Classe",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "Classe",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "Classe",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "Classe",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "Classe",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "Classe",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "Classe",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "Classe",
                value: 0);
        }
    }
}
