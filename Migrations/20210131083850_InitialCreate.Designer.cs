﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using dotnetcore_mvc_postgresql_linux.Data;

namespace dotnetcore_mvc_postgresql_linux.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20210131083850_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("dotnetcore_mvc_postgresql_linux.Models.Article", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int>("password")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
