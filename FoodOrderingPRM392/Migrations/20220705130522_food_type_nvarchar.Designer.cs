﻿// <auto-generated />
using System;
using FoodOrderingCore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodOrderingPRM392.Migrations
{
    [DbContext(typeof(FoodOrderingContext))]
    [Migration("20220705130522_food_type_nvarchar")]
    partial class food_type_nvarchar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodOrderingCore.Data.Food", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("FoodTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ImageSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("FoodTypeId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.FoodStore", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("FoodId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<long>("StoreId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("StoreId", "FoodId")
                        .IsUnique();

                    b.ToTable("FoodStores");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.FoodType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImgSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("FoodTypes");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Total")
                        .HasColumnType("money");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.OrderDetail", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FoodStoreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("money");

                    b.HasKey("OrderId", "FoodStoreId");

                    b.HasIndex("FoodStoreId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.Store", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Latitude")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Longitude")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(15)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<decimal>("WalletAmount")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.Food", b =>
                {
                    b.HasOne("FoodOrderingCore.Data.FoodType", "FoodType")
                        .WithMany("Foods")
                        .HasForeignKey("FoodTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodType");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.FoodStore", b =>
                {
                    b.HasOne("FoodOrderingCore.Data.Food", "Food")
                        .WithMany("FoodStores")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodOrderingCore.Data.Store", "Store")
                        .WithMany("FoodStores")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.Order", b =>
                {
                    b.HasOne("FoodOrderingCore.Data.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.OrderDetail", b =>
                {
                    b.HasOne("FoodOrderingCore.Data.FoodStore", "FoodStore")
                        .WithMany("OrderDetails")
                        .HasForeignKey("FoodStoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodOrderingCore.Data.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodStore");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.User", b =>
                {
                    b.HasOne("FoodOrderingCore.Data.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.Food", b =>
                {
                    b.Navigation("FoodStores");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.FoodStore", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.FoodType", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.Store", b =>
                {
                    b.Navigation("FoodStores");
                });

            modelBuilder.Entity("FoodOrderingCore.Data.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
