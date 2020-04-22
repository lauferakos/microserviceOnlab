﻿// <auto-generated />
using System;
using CinemaTest.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CinemaTest.Migrations
{
    [DbContext(typeof(SearchingContext))]
    [Migration("20200410123221_RoomFkUpdate")]
    partial class RoomFkUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CinemaTest.AggregatesModel.OrderAggregate.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FullPrice")
                        .HasColumnType("int");

                    b.Property<int>("ProjectionFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectionFK");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CinemaTest.AggregatesModel.ProjectionAggregate.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("CinemaTest.AggregatesModel.ProjectionAggregate.Projection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmFK")
                        .HasColumnType("int");

                    b.Property<int>("FreeSeats")
                        .HasColumnType("int");

                    b.Property<int>("RoomFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FilmFK");

                    b.HasIndex("RoomFK");

                    b.ToTable("Projections");
                });

            modelBuilder.Entity("CinemaTest.AggregatesModel.RoomAggregate.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumOfSeats")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("CinemaTest.AggregatesModel.RoomAggregate.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Column")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("RoomFK")
                        .HasColumnType("int");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomFK");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("CinemaTest.AggregatesModel.ViewerAggregate.Viewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderFK");

                    b.ToTable("Viewers");
                });

            modelBuilder.Entity("CinemaTest.AggregatesModel.OrderAggregate.Order", b =>
                {
                    b.HasOne("CinemaTest.AggregatesModel.ProjectionAggregate.Projection", "Projection")
                        .WithMany()
                        .HasForeignKey("ProjectionFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CinemaTest.AggregatesModel.ProjectionAggregate.Projection", b =>
                {
                    b.HasOne("CinemaTest.AggregatesModel.ProjectionAggregate.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaTest.AggregatesModel.RoomAggregate.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CinemaTest.AggregatesModel.RoomAggregate.Seat", b =>
                {
                    b.HasOne("CinemaTest.AggregatesModel.RoomAggregate.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CinemaTest.AggregatesModel.ViewerAggregate.Viewer", b =>
                {
                    b.HasOne("CinemaTest.AggregatesModel.OrderAggregate.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
