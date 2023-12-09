﻿// <auto-generated />
using E_Shop_Catalog.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace E_Shop_Catalog.Migrations
{
    [DbContext(typeof(DataBaseContex))]
    [Migration("20231208151449_InitialDatabase")]
    partial class InitialDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("E_Shop_Catalog.Model.ComputerModel", b =>
                {
                    b.Property<string>("Category_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GPY")
                        .HasColumnType("integer");

                    b.Property<string>("Graphic")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Proccesor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Quantity_Ram")
                        .HasColumnType("integer");

                    b.Property<string>("Ram_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ram_Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("E_Shop_Catalog.Model.ProductModel", b =>
                {
                    b.Property<int>("Id_Category")
                        .HasColumnType("integer");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("ProductModel");
                });
#pragma warning restore 612, 618
        }
    }
}
