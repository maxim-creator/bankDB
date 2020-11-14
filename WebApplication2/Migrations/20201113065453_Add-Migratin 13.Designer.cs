﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Data;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(WebApplication2Context))]
    [Migration("20201113065453_Add-Migratin 13")]
    partial class AddMigratin13
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebDBLybrary.Models.Contribution", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalConditions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContributionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CurrencyID")
                        .HasColumnType("bigint");

                    b.Property<long?>("DepositorID")
                        .HasColumnType("bigint");

                    b.Property<long?>("EmployeeID")
                        .HasColumnType("bigint");

                    b.Property<double>("InterestRate")
                        .HasColumnType("float");

                    b.Property<int>("maxTime")
                        .HasColumnType("int");

                    b.Property<int>("minTime")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CurrencyID");

                    b.HasIndex("DepositorID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("contributions");
                });

            modelBuilder.Entity("WebDBLybrary.Models.Currency", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("exchangeRate")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("currencies");
                });

            modelBuilder.Entity("WebDBLybrary.Models.Depositor", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("EmployeeID")
                        .HasColumnType("bigint");

                    b.Property<string>("adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("amount")
                        .HasColumnType("float");

                    b.Property<double>("amountOfTheRefund")
                        .HasColumnType("float");

                    b.Property<DateTime>("conDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("mark")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pasportData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("retDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("WebDBLybrary.Models.Employee", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<long?>("contributionID")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pasportData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("positionId")
                        .HasColumnType("bigint");

                    b.Property<string>("sex")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("positionId");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("WebDBLybrary.Models.Position", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("duties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("salary")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("WebDBLybrary.Models.Contribution", b =>
                {
                    b.HasOne("WebDBLybrary.Models.Currency", "currerncy")
                        .WithMany("contributions")
                        .HasForeignKey("CurrencyID");

                    b.HasOne("WebDBLybrary.Models.Depositor", "depositor")
                        .WithMany("contributions")
                        .HasForeignKey("DepositorID");

                    b.HasOne("WebDBLybrary.Models.Employee", "employee")
                        .WithMany("contributions")
                        .HasForeignKey("EmployeeID");
                });

            modelBuilder.Entity("WebDBLybrary.Models.Depositor", b =>
                {
                    b.HasOne("WebDBLybrary.Models.Employee", "employee")
                        .WithMany("depositors")
                        .HasForeignKey("EmployeeID");
                });

            modelBuilder.Entity("WebDBLybrary.Models.Employee", b =>
                {
                    b.HasOne("WebDBLybrary.Models.Position", "position")
                        .WithMany("Employees")
                        .HasForeignKey("positionId");
                });
#pragma warning restore 612, 618
        }
    }
}