using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoArma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ARMAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false),
                    Classe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ARMAS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_ARMAS",
                columns: new[] { "Id", "Classe", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 0, 50, "Espada" },
                    { 2, 0, 25, "Adaga" },
                    { 3, 0, 5, "Escudo" },
                    { 4, 0, 35, "Clava" },
                    { 5, 0, 1000, "Estrelança da Aurora Dracônica!!!!!!" },
                    { 6, 0, 60, "Machado" },
                    { 7, 0, 30, "Arco" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ARMAS");
        }
    }
}
