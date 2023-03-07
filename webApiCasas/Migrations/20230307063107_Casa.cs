using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webApiCasas.Migrations
{
    /// <inheritdoc />
    public partial class Casa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "DueñoID",
                table: "Casas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Casas_DueñoID",
                table: "Casas",
                column: "DueñoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Casas_Dueños_DueñoID",
                table: "Casas",
                column: "DueñoID",
                principalTable: "Dueños",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Casas_Dueños_DueñoID",
                table: "Casas");

            migrationBuilder.DropIndex(
                name: "IX_Casas_DueñoID",
                table: "Casas");

            migrationBuilder.DropColumn(
                name: "DueñoID",
                table: "Casas");

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
    }
}
