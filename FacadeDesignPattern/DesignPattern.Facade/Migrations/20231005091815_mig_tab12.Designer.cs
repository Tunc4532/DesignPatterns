﻿// <auto-generated />
using DesignPattern.Facade.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesignPattern.Facade.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231005091815_mig_tab12")]
    partial class mig_tab12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
#pragma warning restore 612, 618
        }
    }
}