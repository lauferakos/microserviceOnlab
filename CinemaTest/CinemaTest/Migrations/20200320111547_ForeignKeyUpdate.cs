using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaTest.Migrations
{
    public partial class ForeignKeyUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectionId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Seats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FullPrice",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectionFK",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Films",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "FullPrice",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProjectionFK",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "ProjectionId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
