﻿// <auto-generated />
using Formula1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Formula1.Migrations
{
    [DbContext(typeof(Formula1DbContext))]
    partial class Formula1DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Formula1.Entities.Drivers", b =>
                {
                    b.Property<int>("DriversID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiverSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DriverNumber")
                        .HasColumnType("int");

                    b.HasKey("DriversID");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Formula1.Entities.Teams", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeamBase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamChassis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamChief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamFastestLaps")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamPolePositions")
                        .HasColumnType("int");

                    b.Property<string>("TeamPowerUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamWorldChampionships")
                        .HasColumnType("int");

                    b.HasKey("TeamID");

                    b.ToTable("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
