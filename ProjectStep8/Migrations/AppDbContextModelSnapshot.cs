﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectStep8.Models;

namespace ProjectStep8.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectStep8.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AftermarketOrOem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ComponentCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComponentCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ComponentCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ComponentManufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComponentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("LaborCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PurchaseVendor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReplacedMileage")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("WarrantyExpiration")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("Component");
                });

            modelBuilder.Entity("ProjectStep8.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmailAddress")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("ProjectStep8.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutVehicle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrakeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrivetrainType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrontSuspensionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horsepower")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PurchaseDate")
                        .HasColumnType("date");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<string>("RearSuspensionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SteeringType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Torque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransmissionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("ProjectStep8.Models.Component", b =>
                {
                    b.HasOne("ProjectStep8.Models.Vehicle", "Vehicle")
                        .WithMany("Components")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
