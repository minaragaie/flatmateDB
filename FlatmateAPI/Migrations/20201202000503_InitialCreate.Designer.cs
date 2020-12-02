﻿// <auto-generated />
using System;
using FlatmateAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlatmateAPI.Migrations
{
    [DbContext(typeof(FlatmateDBContext))]
    [Migration("20201202000503_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("FlatmateAPI.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ActivityType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<int>("HouseId")
                        .HasColumnType("int");

                    b.Property<int>("Privilege")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.HasIndex("UserId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("FlatmateAPI.Models.ActivityType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Label")
                        .HasMaxLength(40)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ActivityType");
                });

            modelBuilder.Entity("FlatmateAPI.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("FlatmateAPI.Models.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Location")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("House");
                });

            modelBuilder.Entity("FlatmateAPI.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("FlatmateAPI.Models.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Label")
                        .HasMaxLength(40)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ItemType");
                });

            modelBuilder.Entity("FlatmateAPI.Models.List", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<int>("Label")
                        .HasMaxLength(40)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("List");
                });

            modelBuilder.Entity("FlatmateAPI.Models.ListItem", b =>
                {
                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("ListId")
                        .HasColumnType("int");

                    b.Property<int?>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasBeenPurchased")
                        .HasColumnType("bit");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ItemTypeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("PhotoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quanitiy")
                        .HasColumnType("int");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("ItemId", "ListId");

                    b.HasIndex("ActivityId");

                    b.HasIndex("ListId");

                    b.ToTable("ListItem");
                });

            modelBuilder.Entity("FlatmateAPI.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("FlatmateAPI.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("FlatmateAPI.Models.StoreItem", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ItemId", "StoreId");

                    b.HasIndex("StoreId");

                    b.ToTable("StoreItem");
                });

            modelBuilder.Entity("FlatmateAPI.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Notes")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("OnProcess")
                        .HasColumnType("bit");

                    b.Property<bool>("Repeat")
                        .HasColumnType("bit");

                    b.Property<int>("TaskTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("User")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("User");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("FlatmateAPI.Models.TaskType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Label")
                        .HasMaxLength(40)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TaskType");
                });

            modelBuilder.Entity("FlatmateAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ApiKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<bool>("IsAnonymous")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLoginAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("FlatmateAPI.Models.UserHouse", b =>
                {
                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("HouseId")
                        .HasColumnType("int");

                    b.Property<bool>("Accepted")
                        .HasColumnType("bit");

                    b.Property<int?>("ActivityId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("UserId", "HouseId");

                    b.HasIndex("ActivityId");

                    b.HasIndex("HouseId");

                    b.ToTable("UserHouse");
                });

            modelBuilder.Entity("FlatmateAPI.Models.Activity", b =>
                {
                    b.HasOne("FlatmateAPI.Models.House", null)
                        .WithMany("Activities")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlatmateAPI.Models.User", "User")
                        .WithMany("Activities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FlatmateAPI.Models.Comment", b =>
                {
                    b.HasOne("FlatmateAPI.Models.Activity", "Activity")
                        .WithMany("Comments")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("FlatmateAPI.Models.List", b =>
                {
                    b.HasOne("FlatmateAPI.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("FlatmateAPI.Models.ListItem", b =>
                {
                    b.HasOne("FlatmateAPI.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId");

                    b.HasOne("FlatmateAPI.Models.Item", "Item")
                        .WithMany("Lists")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlatmateAPI.Models.List", "List")
                        .WithMany("Items")
                        .HasForeignKey("ListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("Item");

                    b.Navigation("List");
                });

            modelBuilder.Entity("FlatmateAPI.Models.Post", b =>
                {
                    b.HasOne("FlatmateAPI.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("FlatmateAPI.Models.StoreItem", b =>
                {
                    b.HasOne("FlatmateAPI.Models.Item", "Item")
                        .WithMany("Stores")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlatmateAPI.Models.Store", "Store")
                        .WithMany("Items")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("FlatmateAPI.Models.Task", b =>
                {
                    b.HasOne("FlatmateAPI.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlatmateAPI.Models.User", "AssignedTo")
                        .WithMany()
                        .HasForeignKey("User");

                    b.Navigation("Activity");

                    b.Navigation("AssignedTo");
                });

            modelBuilder.Entity("FlatmateAPI.Models.UserHouse", b =>
                {
                    b.HasOne("FlatmateAPI.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId");

                    b.HasOne("FlatmateAPI.Models.House", "House")
                        .WithMany("Users")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlatmateAPI.Models.User", "User")
                        .WithMany("Houses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("House");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FlatmateAPI.Models.Activity", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("FlatmateAPI.Models.House", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FlatmateAPI.Models.Item", b =>
                {
                    b.Navigation("Lists");

                    b.Navigation("Stores");
                });

            modelBuilder.Entity("FlatmateAPI.Models.List", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("FlatmateAPI.Models.Store", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("FlatmateAPI.Models.User", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Houses");
                });
#pragma warning restore 612, 618
        }
    }
}
