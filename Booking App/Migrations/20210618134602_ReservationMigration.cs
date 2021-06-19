using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_App.Migrations
{
    public partial class ReservationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookedRooms_Users");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: true),
                    Room_Id = table.Column<int>(type: "int", nullable: true),
                    Hotel_Id = table.Column<int>(type: "int", nullable: true),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Hotels_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_Room_Id",
                        column: x => x.Room_Id,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_Hotel_Id",
                table: "Reservations",
                column: "Hotel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_Room_Id",
                table: "Reservations",
                column: "Room_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_User_Id",
                table: "Reservations",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.CreateTable(
                name: "BookedRooms_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Room_Id = table.Column<int>(type: "int", nullable: true),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedRooms_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookedRooms_Users_Rooms_Room_Id",
                        column: x => x.Room_Id,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookedRooms_Users_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookedRooms_Users_Room_Id",
                table: "BookedRooms_Users",
                column: "Room_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BookedRooms_Users_User_Id",
                table: "BookedRooms_Users",
                column: "User_Id");
        }
    }
}
