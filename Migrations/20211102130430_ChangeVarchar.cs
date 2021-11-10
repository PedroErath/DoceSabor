using Microsoft.EntityFrameworkCore.Migrations;

namespace DoceSabor.Migrations
{
    public partial class ChangeVarchar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Opiniao",
                table: "Feedbacks",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Feedbacks",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Opiniao",
                table: "Feedbacks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Feedbacks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
