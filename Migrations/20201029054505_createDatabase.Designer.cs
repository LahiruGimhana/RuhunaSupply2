﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RuhunaSupply.Data;

namespace RuhunaSupply.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201029054505_createDatabase")]
    partial class createDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RuhunaSupply.Model.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId1")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId2")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId3")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("RuhunaSupply.Model.PurchaseRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("BudgetAllocation")
                        .HasColumnType("double");

                    b.Property<int>("Faculty")
                        .HasColumnType("int");

                    b.Property<string>("FundGoes")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IsInProcumentPlan")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Project")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Purpose")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TelephonNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Vote")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("PurchaseRequests");
                });

            modelBuilder.Entity("RuhunaSupply.Model.PurchaseRequestItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("EstimatedCost")
                        .HasColumnType("double");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseRequestId")
                        .HasColumnType("int");

                    b.Property<int>("QtyRequired")
                        .HasColumnType("int");

                    b.Property<int>("QtySupplied")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("double");

                    b.Property<double>("TotalValue")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("PurchaseRequestItems");
                });

            modelBuilder.Entity("RuhunaSupply.Model.PurchaseRequestItemSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PurchaseRequestItemId")
                        .HasColumnType("int");

                    b.Property<int>("SpecificationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PurchaseRequestItemSpecifications");
                });

            modelBuilder.Entity("RuhunaSupply.Model.Quatation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PurchaseRequestId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("SupplyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Quatations");
                });

            modelBuilder.Entity("RuhunaSupply.Model.QuatationItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IsSupply")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseRequestItemId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int>("QuatationId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("QuatationItems");
                });

            modelBuilder.Entity("RuhunaSupply.Model.QuatationItemSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("QuatationItemId")
                        .HasColumnType("int");

                    b.Property<string>("Satisfied")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("SpecificationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("QuatationItemSpecifications");
                });

            modelBuilder.Entity("RuhunaSupply.Model.Specification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SpecificationCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Specification");
                });

            modelBuilder.Entity("RuhunaSupply.Model.SpecificationCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descriptiopn")
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("SpecificationCategories");
                });

            modelBuilder.Entity("RuhunaSupply.Model.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BusinessAddress")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("BusinessMail")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("BusinessName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Category2Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("RegisterNumber")
                        .HasColumnType("int");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("RuhunaSupply.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Admin")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MergedId")
                        .HasColumnType("int");

                    b.Property<string>("PermissionList")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RuhunaSupply.Model.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Privileges")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("RuhunaSupply.Model.UserName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Table")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserNames");
                });

            modelBuilder.Entity("RuhunaSupply.Model.UserPurchaseRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Involvement")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseRequestId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserPurchaseRequests");
                });
#pragma warning restore 612, 618
        }
    }
}