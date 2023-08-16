﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using efcore_7._0._10;

#nullable disable

namespace efcore_7._0._10.Migrations
{
    [DbContext(typeof(IssueDbContext))]
    [Migration("20230816072655_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("efcore_7._0._10.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ISSUE_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(1)
                        .HasColumnType("NUMBER(1)")
                        .HasDefaultValue(0)
                        .HasColumnName("IS_DELETED");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NAME");

                    b.Property<decimal?>("Weight")
                        .HasPrecision(8, 5)
                        .HasColumnType("NUMBER(8,5)")
                        .HasColumnName("WEIGHT");

                    b.HasKey("Id");

                    b.ToTable("ISSUE", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
