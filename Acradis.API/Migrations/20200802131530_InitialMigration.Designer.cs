﻿// <auto-generated />
using System;
using Acradis.API.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Acradis.API.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20200802131530_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Acradis.API.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Cost")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<decimal?>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            Cost = 345.00m,
                            Quantity = 2,
                            Title = "Backplate replacement, ABS Plastic Louver, 3 - Section"
                        },
                        new
                        {
                            Id = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            Cost = 450.00m,
                            Quantity = 12,
                            Title = "Backplate replacement, ABS Plastic Louver, 4 - Section (FYA)"
                        },
                        new
                        {
                            Id = new Guid("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"),
                            Cost = 500.00m,
                            Quantity = 8,
                            Title = "Backplate replacement, ABS Plastic Louver, 4 - Section (T-shaped protected only)"
                        },
                        new
                        {
                            Id = new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                            Cost = 20.00m,
                            Quantity = 48,
                            Title = "Backplate replacement, ABS Plastic Louver, 5 - Section"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}