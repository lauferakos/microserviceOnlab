using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaTest.Migrations
{
    public partial class NavigationPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Viewers");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "Projections");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Projections");

            migrationBuilder.AddColumn<int>(
                name: "OrderFK",
                table: "Viewers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FilmFK",
                table: "Projections",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomFK",
                table: "Projections",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Viewers_OrderFK",
                table: "Viewers",
                column: "OrderFK");

            migrationBuilder.CreateIndex(
                name: "IX_Projections_FilmFK",
                table: "Projections",
                column: "FilmFK");

            migrationBuilder.CreateIndex(
                name: "IX_Projections_RoomFK",
                table: "Projections",
                column: "RoomFK");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProjectionFK",
                table: "Orders",
                column: "ProjectionFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Projections_ProjectionFK",
                table: "Orders",
                column: "ProjectionFK",
                principalTable: "Projections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projections_Films_FilmFK",
                table: "Projections",
                column: "FilmFK",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projections_Rooms_RoomFK",
                table: "Projections",
                column: "RoomFK",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Viewers_Orders_OrderFK",
                table: "Viewers",
                column: "OrderFK",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Projections_ProjectionFK",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Projections_Films_FilmFK",
                table: "Projections");

            migrationBuilder.DropForeignKey(
                name: "FK_Projections_Rooms_RoomFK",
                table: "Projections");

            migrationBuilder.DropForeignKey(
                name: "FK_Viewers_Orders_OrderFK",
                table: "Viewers");

            migrationBuilder.DropIndex(
                name: "IX_Viewers_OrderFK",
                table: "Viewers");

            migrationBuilder.DropIndex(
                name: "IX_Projections_FilmFK",
                table: "Projections");

            migrationBuilder.DropIndex(
                name: "IX_Projections_RoomFK",
                table: "Projections");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProjectionFK",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderFK",
                table: "Viewers");

            migrationBuilder.DropColumn(
                name: "FilmFK",
                table: "Projections");

            migrationBuilder.DropColumn(
                name: "RoomFK",
                table: "Projections");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Viewers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "Projections",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Projections",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
