using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webApiCasas.Migrations
{
    /// <inheritdoc />
    public partial class Dueño : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ID_DueñoId",
                table: "Casas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Casas_ID_DueñoId",
                table: "Casas",
                column: "ID_DueñoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Casas_Dueños_ID_DueñoId",
                table: "Casas",
                column: "ID_DueñoId",
                principalTable: "Dueños",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Casas_Dueños_ID_DueñoId",
                table: "Casas");

            migrationBuilder.DropIndex(
                name: "IX_Casas_ID_DueñoId",
                table: "Casas");

            migrationBuilder.DropColumn(
                name: "ID_DueñoId",
                table: "Casas");
        }
    }
}
