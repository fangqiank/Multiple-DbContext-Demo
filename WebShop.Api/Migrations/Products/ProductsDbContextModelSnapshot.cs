﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebShop.Api.Products;

#nullable disable

namespace WebShop.Api.Migrations.Products
{
    [DbContext(typeof(ProductsDbContext))]
    partial class ProductsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("products")
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebShop.Api.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products", "products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f2623d69-0335-4857-bee2-f6ac33f81fff"),
                            Name = "Product #1",
                            Price = 100m
                        },
                        new
                        {
                            Id = new Guid("ea9930e6-d13c-40c2-aa42-587c15ec2146"),
                            Name = "Product #2",
                            Price = 200m
                        },
                        new
                        {
                            Id = new Guid("3bd20657-9c3a-4d00-85f3-b1898dff6701"),
                            Name = "Product #3",
                            Price = 300m
                        },
                        new
                        {
                            Id = new Guid("3609548c-7185-4c8e-b6c3-ca98e326d60f"),
                            Name = "Product #4",
                            Price = 400m
                        },
                        new
                        {
                            Id = new Guid("f825d544-feda-4d44-97d4-9c8db3423a3b"),
                            Name = "Product #5",
                            Price = 500m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
