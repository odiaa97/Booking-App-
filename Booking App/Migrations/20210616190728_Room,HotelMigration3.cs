using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_App.Migrations
{
    public partial class RoomHotelMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedRooms_Users_Rooms_Room_IdId",
                table: "BookedRooms_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_BookedRooms_Users_Users_User_IdId",
                table: "BookedRooms_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Room_Types_Type_id_fkId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "Type_id_fkId",
                table: "Rooms",
                newName: "Type_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_Type_id_fkId",
                table: "Rooms",
                newName: "IX_Rooms_Type_Id");

            migrationBuilder.RenameColumn(
                name: "User_IdId",
                table: "BookedRooms_Users",
                newName: "User_Id");

            migrationBuilder.RenameColumn(
                name: "Room_IdId",
                table: "BookedRooms_Users",
                newName: "Room_Id");

            migrationBuilder.RenameIndex(
                name: "IX_BookedRooms_Users_User_IdId",
                table: "BookedRooms_Users",
                newName: "IX_BookedRooms_Users_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_BookedRooms_Users_Room_IdId",
                table: "BookedRooms_Users",
                newName: "IX_BookedRooms_Users_Room_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedRooms_Users_Rooms_Room_Id",
                table: "BookedRooms_Users",
                column: "Room_Id",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookedRooms_Users_Users_User_Id",
                table: "BookedRooms_Users",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Room_Types_Type_Id",
                table: "Rooms",
                column: "Type_Id",
                principalTable: "Room_Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedRooms_Users_Rooms_Room_Id",
                table: "BookedRooms_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_BookedRooms_Users_Users_User_Id",
                table: "BookedRooms_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Room_Types_Type_Id",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "Type_Id",
                table: "Rooms",
                newName: "Type_id_fkId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_Type_Id",
                table: "Rooms",
                newName: "IX_Rooms_Type_id_fkId");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "BookedRooms_Users",
                newName: "User_IdId");

            migrationBuilder.RenameColumn(
                name: "Room_Id",
                table: "BookedRooms_Users",
                newName: "Room_IdId");

            migrationBuilder.RenameIndex(
                name: "IX_BookedRooms_Users_User_Id",
                table: "BookedRooms_Users",
                newName: "IX_BookedRooms_Users_User_IdId");

            migrationBuilder.RenameIndex(
                name: "IX_BookedRooms_Users_Room_Id",
                table: "BookedRooms_Users",
                newName: "IX_BookedRooms_Users_Room_IdId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedRooms_Users_Rooms_Room_IdId",
                table: "BookedRooms_Users",
                column: "Room_IdId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookedRooms_Users_Users_User_IdId",
                table: "BookedRooms_Users",
                column: "User_IdId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Room_Types_Type_id_fkId",
                table: "Rooms",
                column: "Type_id_fkId",
                principalTable: "Room_Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
