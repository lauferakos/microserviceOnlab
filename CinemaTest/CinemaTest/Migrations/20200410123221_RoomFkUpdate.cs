using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaTest.Migrations
{
    public partial class RoomFkUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomFK",
                table: "Seats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Seats_RoomFK",
                table: "Seats",
                column: "RoomFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Rooms_RoomFK",
                table: "Seats",
                column: "RoomFK",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Rooms_RoomFK",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_RoomFK",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "RoomFK",
                table: "Seats");
        }
    }
}
