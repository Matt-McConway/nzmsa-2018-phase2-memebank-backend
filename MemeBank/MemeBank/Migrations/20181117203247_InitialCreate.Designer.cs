﻿// <auto-generated />
using MemeBank.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MemeBank.Migrations
{
    [DbContext(typeof(MemeBankContext))]
    [Migration("20181117203247_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("MemeBank.Models.MemeItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Height");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.Property<string>("Uploaded");

                    b.Property<string>("Url");

                    b.Property<string>("Width");

                    b.HasKey("Id");

                    b.ToTable("MemeItem");
                });
#pragma warning restore 612, 618
        }
    }
}
