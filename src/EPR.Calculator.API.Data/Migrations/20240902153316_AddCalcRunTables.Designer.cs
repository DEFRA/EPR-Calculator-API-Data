﻿// <auto-generated />
using System;
using EPR.Calculator.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EPR.Calculator.API.Data.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240902153316_AddCalcRunTables")]
    partial class AddCalcRunTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EPR.Calculator.API.Data.DataModels.CalculatorRun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CalculatorRunClassificationId")
                        .HasColumnType("int")
                        .HasColumnName("calculator_run_classification_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)")
                        .HasColumnName("created_by");

                    b.Property<string>("Financial_Year")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("financial_year");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.HasIndex("CalculatorRunClassificationId");

                    b.ToTable("calculator_run");
                });

            modelBuilder.Entity("EPR.Calculator.API.Data.DataModels.CalculatorRunClassification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)")
                        .HasColumnName("created_by");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("calculator_run_classification");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 2, 16, 33, 15, 335, DateTimeKind.Local).AddTicks(8091),
                            CreatedBy = "Test User",
                            Status = "IN THE QUEUE"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 2, 16, 33, 15, 335, DateTimeKind.Local).AddTicks(8097),
                            CreatedBy = "Test User",
                            Status = "RUNNING"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 9, 2, 16, 33, 15, 335, DateTimeKind.Local).AddTicks(8102),
                            CreatedBy = "Test User",
                            Status = "UNCLASSIFIED"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 9, 2, 16, 33, 15, 335, DateTimeKind.Local).AddTicks(8106),
                            CreatedBy = "Test User",
                            Status = "PLAY"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 9, 2, 16, 33, 15, 335, DateTimeKind.Local).AddTicks(8110),
                            CreatedBy = "Test User",
                            Status = "ERROR"
                        });
                });

            modelBuilder.Entity("EPR.Calculator.API.Data.DataModels.DefaultParameterSettingDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DefaultParameterSettingMasterId")
                        .HasColumnType("int")
                        .HasColumnName("default_parameter_setting_master_id");

                    b.Property<string>("ParameterUniqueReferenceId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("parameter_unique_ref");

                    b.Property<decimal>("ParameterValue")
                        .HasPrecision(18, 3)
                        .HasColumnType("decimal(18,3)")
                        .HasColumnName("parameter_value");

                    b.HasKey("Id");

                    b.HasIndex("DefaultParameterSettingMasterId");

                    b.HasIndex("ParameterUniqueReferenceId");

                    b.ToTable("default_parameter_setting_detail");
                });

            modelBuilder.Entity("EPR.Calculator.API.Data.DataModels.DefaultParameterSettingMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("EffectiveFrom")
                        .HasColumnType("datetime2")
                        .HasColumnName("effective_from");

                    b.Property<DateTime?>("EffectiveTo")
                        .HasColumnType("datetime2")
                        .HasColumnName("effective_to");

                    b.Property<string>("ParameterYear")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("parameter_year");

                    b.HasKey("Id");

                    b.ToTable("default_parameter_setting_master");
                });

            modelBuilder.Entity("EPR.Calculator.API.Data.DataModels.DefaultParameterTemplateMaster", b =>
                {
                    b.Property<string>("ParameterUniqueReferenceId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("parameter_unique_ref");

                    b.Property<string>("ParameterCategory")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("parameter_category");

                    b.Property<string>("ParameterType")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("parameter_type");

                    b.Property<decimal>("ValidRangeFrom")
                        .HasPrecision(18, 3)
                        .HasColumnType("decimal(18, 3)")
                        .HasColumnName("valid_Range_from");

                    b.Property<decimal>("ValidRangeTo")
                        .HasPrecision(18, 3)
                        .HasColumnType("decimal(18,3)")
                        .HasColumnName("valid_Range_to");

                    b.HasKey("ParameterUniqueReferenceId");

                    b.ToTable("default_parameter_template_master");

                    b.HasData(
                        new
                        {
                            ParameterUniqueReferenceId = "COMC-AL",
                            ParameterCategory = "Communication costs",
                            ParameterType = "Aluminium",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "COMC-FC",
                            ParameterCategory = "Communication costs",
                            ParameterType = "Fibre composite",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "COMC-GL",
                            ParameterCategory = "Communication costs",
                            ParameterType = "Glass",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "COMC-PC",
                            ParameterCategory = "Communication costs",
                            ParameterType = "Paper or card",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "COMC-PL",
                            ParameterCategory = "Communication costs",
                            ParameterType = "Plastic",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "COMC-ST",
                            ParameterCategory = "Communication costs",
                            ParameterType = "Steel",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "COMC-WD",
                            ParameterCategory = "Communication costs",
                            ParameterType = "Wood",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "COMC-OT",
                            ParameterCategory = "Communication costs",
                            ParameterType = "Other",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "SAOC-ENG",
                            ParameterCategory = "Scheme administrator operating costs",
                            ParameterType = "England",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "SAOC-WLS",
                            ParameterCategory = "Scheme administrator operating costs",
                            ParameterType = "Wales",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "SAOC-SCT",
                            ParameterCategory = "Scheme administrator operating costs",
                            ParameterType = "Scotland",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "SAOC-NIR",
                            ParameterCategory = "Scheme administrator operating costs",
                            ParameterType = "Northern Ireland",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LAPC-ENG",
                            ParameterCategory = "Local authority data preparation costs",
                            ParameterType = "England",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LAPC-WLS",
                            ParameterCategory = "Local authority data preparation costs",
                            ParameterType = "Wales",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LAPC-SCT",
                            ParameterCategory = "Local authority data preparation costs",
                            ParameterType = "Scotland",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LAPC-NIR",
                            ParameterCategory = "Local authority data preparation costs",
                            ParameterType = "Northern Ireland",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "SCSC-ENG",
                            ParameterCategory = "Scheme setup costs",
                            ParameterType = "England",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "SCSC-WLS",
                            ParameterCategory = "Scheme setup costs",
                            ParameterType = "Wales",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "SCSC-SCT",
                            ParameterCategory = "Scheme setup costs",
                            ParameterType = "Scotland",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "SCSC-NIR",
                            ParameterCategory = "Scheme setup costs",
                            ParameterType = "Northern Ireland",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LRET-AL",
                            ParameterCategory = "Late reporting tonnage",
                            ParameterType = "Aluminium",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LRET-FC",
                            ParameterCategory = "Late reporting tonnage",
                            ParameterType = "Aluminium",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LRET-GL",
                            ParameterCategory = "Late reporting tonnage",
                            ParameterType = "Aluminium",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LRET-PC",
                            ParameterCategory = "Late reporting tonnage",
                            ParameterType = "Aluminium",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LRET-PL",
                            ParameterCategory = "Late reporting tonnage",
                            ParameterType = "Aluminium",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LRET-ST",
                            ParameterCategory = "Late reporting tonnage",
                            ParameterType = "Aluminium",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LRET-WD",
                            ParameterCategory = "Late reporting tonnage",
                            ParameterType = "Aluminium",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LRET-OT",
                            ParameterCategory = "Late reporting tonnage",
                            ParameterType = "Aluminium",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "BADEBT-P",
                            ParameterCategory = "Communication costs",
                            ParameterType = "Aluminium",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "MATT-AI",
                            ParameterCategory = "Materiality threshold",
                            ParameterType = "Amount Increase",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "MATT-AD",
                            ParameterCategory = "Materiality threshold",
                            ParameterType = "Amount Decrease",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "MATT-PI",
                            ParameterCategory = "Materiality threshold",
                            ParameterType = "Percent Increase",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 1000.00m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "MATT-PD",
                            ParameterCategory = "Materiality threshold",
                            ParameterType = "Percent Decrease",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = -1000.00m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "TONT-AI",
                            ParameterCategory = "Tonnage change threshold",
                            ParameterType = "Amount Increase",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "TONT-DI",
                            ParameterCategory = "Tonnage change threshold",
                            ParameterType = "Amount Decrease",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "TONT-PI",
                            ParameterCategory = "Tonnage change threshold",
                            ParameterType = "Percent Increase",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 1000.00m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "TONT-PD",
                            ParameterCategory = "Tonnage change threshold",
                            ParameterType = "Percent Decrease",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = -1000.00m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LEVY-ENG",
                            ParameterCategory = "Levy",
                            ParameterType = "England",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LEVY-WLS",
                            ParameterCategory = "Levy",
                            ParameterType = "Wales",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LEVY-SCT",
                            ParameterCategory = "Levy",
                            ParameterType = "Scotland",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        },
                        new
                        {
                            ParameterUniqueReferenceId = "LEVY-NIR",
                            ParameterCategory = "Levy",
                            ParameterType = "Northern Ireland",
                            ValidRangeFrom = 0m,
                            ValidRangeTo = 999999999.99m
                        });
                });

            modelBuilder.Entity("EPR.Calculator.API.Data.DataModels.CalculatorRun", b =>
                {
                    b.HasOne("EPR.Calculator.API.Data.DataModels.CalculatorRunClassification", null)
                        .WithMany("CalculatorRunDetails")
                        .HasForeignKey("CalculatorRunClassificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EPR.Calculator.API.Data.DataModels.DefaultParameterSettingDetail", b =>
                {
                    b.HasOne("EPR.Calculator.API.Data.DataModels.DefaultParameterSettingMaster", "DefaultParameterSettingMaster")
                        .WithMany("Details")
                        .HasForeignKey("DefaultParameterSettingMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EPR.Calculator.API.Data.DataModels.DefaultParameterTemplateMaster", "ParameterUniqueReference")
                        .WithMany()
                        .HasForeignKey("ParameterUniqueReferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DefaultParameterSettingMaster");

                    b.Navigation("ParameterUniqueReference");
                });

            modelBuilder.Entity("EPR.Calculator.API.Data.DataModels.CalculatorRunClassification", b =>
                {
                    b.Navigation("CalculatorRunDetails");
                });

            modelBuilder.Entity("EPR.Calculator.API.Data.DataModels.DefaultParameterSettingMaster", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
