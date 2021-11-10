using Microsoft.EntityFrameworkCore.Migrations;

namespace DoceSabor.Migrations
{
    public partial class ChangeVarcharNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Admins",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Admins",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Admins",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Admins",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
