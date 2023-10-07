﻿// <auto-generated />
using System;
using DesignPattern.Facade.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesignPattern.Facade.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DesignPattern.Facade.DAL.Coustemer", b =>
                {
                    b.Property<int>("CoustumerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoustumerId"), 1L, 1);

                    b.Property<string>("CoustumerAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoustumerCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoustumerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoustumerSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoustumerId");

                    b.ToTable("Coustemers");
                });

            modelBuilder.Entity("DesignPattern.Facade.DAL.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<int?>("CoustemerCoustumerId")
                        .HasColumnType("int");

                    b.Property<int>("CoustumerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.HasIndex("CoustemerCoustumerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DesignPattern.Facade.DAL.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailId"), 1L, 1);

                    b.Property<int?>("CoustemerCoustumerId")
                        .HasColumnType("int");

                    b.Property<int>("CoustumerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductCount")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProductTotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("CoustemerCoustumerId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DesignPattern.Facade.DAL.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("ProductCatagory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductStock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DesignPattern.Facade.DAL.Order", b =>
                {
                    b.HasOne("DesignPattern.Facade.DAL.Coustemer", "Coustemer")
                        .WithMany("Orders")
                        .HasForeignKey("CoustemerCoustumerId");

                    b.Navigation("Coustemer");
                });

            modelBuilder.Entity("DesignPattern.Facade.DAL.OrderDetail", b =>
                {
                    b.HasOne("DesignPattern.Facade.DAL.Coustemer", "Coustemer")
                        .WithMany("orderDetails")
                        .HasForeignKey("CoustemerCoustumerId");

                    b.HasOne("DesignPattern.Facade.DAL.Order", "Order")
                        .WithMany("orderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DesignPattern.Facade.DAL.Product", "Product")
                        .WithMany("orderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coustemer");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DesignPattern.Facade.DAL.Coustemer", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("orderDetails");
                });

            modelBuilder.Entity("DesignPattern.Facade.DAL.Order", b =>
                {
                    b.Navigation("orderDetails");
                });

            modelBuilder.Entity("DesignPattern.Facade.DAL.Product", b =>
                {
                    b.Navigation("orderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
