using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_App.Migrations
{
    public partial class Roomchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Room_Types_Type_Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Type_Id",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Type_Id",
                table: "Rooms");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Rooms");

            migrationBuilder.AddColumn<int>(
                name: "Type_Id",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Type_Id",
                table: "Rooms",
                column: "Type_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Room_Types_Type_Id",
                table: "Rooms",
                column: "Type_Id",
                principalTable: "Room_Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
