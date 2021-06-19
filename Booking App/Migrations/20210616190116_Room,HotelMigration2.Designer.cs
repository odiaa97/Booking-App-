﻿// <auto-generated />
using System;
using Booking_App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Booking_App.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210616190116_Room,HotelMigration2")]
    partial class RoomHotelMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Booking_App.Entities.BookedRooms_Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Room_IdId")
                        .HasColumnType("int");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.Property<int?>("User_IdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Room_IdId");

                    b.HasIndex("User_IdId");

                    b.ToTable("BookedRooms_Users");
                });

            modelBuilder.Entity("Booking_App.Entities.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Booking_App.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Booked")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("Type_id_fkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Type_id_fkId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Booking_App.Entities.Room_Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Room_Types");
                });

            modelBuilder.Entity("Booking_App.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Booking_App.Entities.BookedRooms_Users", b =>
                {
                    b.HasOne("Booking_App.Entities.Room", "Room_Id")
                        .WithMany()
                        .HasForeignKey("Room_IdId");

                    b.HasOne("Booking_App.Entities.User", "User_Id")
                        .WithMany()
                        .HasForeignKey("User_IdId");

                    b.Navigation("Room_Id");

                    b.Navigation("User_Id");
                });

            modelBuilder.Entity("Booking_App.Entities.Room", b =>
                {
                    b.HasOne("Booking_App.Entities.Room_Type", "Type_id_fk")
                        .WithMany()
                        .HasForeignKey("Type_id_fkId");

                    b.Navigation("Type_id_fk");
                });
#pragma warning restore 612, 618
        }
    }
}