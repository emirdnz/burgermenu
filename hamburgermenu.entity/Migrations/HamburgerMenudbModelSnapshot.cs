﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hamburgermenu.context;

#nullable disable

namespace hamburgermenu.data.Migrations
{
    [DbContext(typeof(HamburgerMenudb))]
    partial class HamburgerMenudbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hamburgermenu.entites.HamburgerMenuName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MenuListID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2);

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.HasKey("Id");

                    b.HasIndex("MenuListID");

                    b.ToTable("hamburgermenunames");
                });

            modelBuilder.Entity("hamburgermenu.entitiy.entites.Drinks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MenuListID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2);

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.HasKey("Id");

                    b.HasIndex("MenuListID");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("hamburgermenu.entitiy.entites.MenuList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.HasKey("ID");

                    b.ToTable("MenuLists");
                });

            modelBuilder.Entity("hamburgermenu.entitiy.entites.Orders", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("hamburgermenu.entitiy.entites.Sauce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MenuListID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2);

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.HasKey("Id");

                    b.HasIndex("MenuListID");

                    b.ToTable("Sauces");
                });

            modelBuilder.Entity("hamburgermenu.entitiy.entites.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("hamburgermenu.entites.HamburgerMenuName", b =>
                {
                    b.HasOne("hamburgermenu.entitiy.entites.MenuList", null)
                        .WithMany("menuler")
                        .HasForeignKey("MenuListID");
                });

            modelBuilder.Entity("hamburgermenu.entitiy.entites.Drinks", b =>
                {
                    b.HasOne("hamburgermenu.entitiy.entites.MenuList", null)
                        .WithMany("icecekler")
                        .HasForeignKey("MenuListID");
                });

            modelBuilder.Entity("hamburgermenu.entitiy.entites.Sauce", b =>
                {
                    b.HasOne("hamburgermenu.entitiy.entites.MenuList", null)
                        .WithMany("soslar")
                        .HasForeignKey("MenuListID");
                });

            modelBuilder.Entity("hamburgermenu.entitiy.entites.MenuList", b =>
                {
                    b.Navigation("icecekler");

                    b.Navigation("menuler");

                    b.Navigation("soslar");
                });
#pragma warning restore 612, 618
        }
    }
}
